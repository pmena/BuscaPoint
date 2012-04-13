using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using AplicacionREST.Dominio;
using AplicacionMVC.PuntuacionWS;


namespace AplicacionMVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private string alumnoRESTService = "http://localhost:2998/Ubigeos.svc/Ubigeos/2/15/01";
        private string categoriaRESTService = "http://localhost:2998/CategoriaServicios.svc/CategoriaServicios";
        private string busquedaRESTService = "http://localhost:2998/Empresas.svc/Empresas/1/15/01/22/03/karaoke";       

        JavaScriptSerializer js = new JavaScriptSerializer();

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection formCollection)
        {            
            String txtUsuario = formCollection["txt_login"].ToString();
            String txtClave = formCollection["txt_clave"].ToString();

            UsuarioWS.Service_UsuariosClient ws = new UsuarioWS.Service_UsuariosClient();
            String result = ws.Login_usuario(txtUsuario, txtClave);
            if (result.Equals("True"))
            {
                AplicacionMVC.UsuarioWS.Usuario usr=ws.Obtener_Usuario(txtUsuario);
                String url = string.Empty;
                try
                {
                    String dist=string.Empty;
                    String dep = string.Empty;
                    dist = (usr.idDpto < 10) ? "0"+usr.idDpto.ToString() : usr.idDpto.ToString();
                    dep = (usr.idDistrito < 10) ? "0" + usr.idDistrito.ToString() : usr.idDistrito.ToString();

                    url = "http://localhost:2998/Ubigeos.svc/Ubigeos/Distrito/" + dist + "/" + dep + "/01";

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = "GET";
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    StreamReader reader = new StreamReader(res.GetResponseStream());
                    string ubigeosJson = reader.ReadToEnd();
                    ubigeosJson = ubigeosJson.Trim();
                    String ubigeo = ubigeosJson.Substring(1, ubigeosJson.Length - 2);
                    
                    Session["Usuario"] = txtUsuario.ToString();
                    Session["Usuario_dist"] = dist;
                    Session["Usuario_dep"] = dep;
                    Session["Usuario_Posicion"] = ubigeo;
                }
                catch (Exception ex) {
                    Response.Write(ex.Message.ToString()+ " y <br />"+url);
                }               
            }
            else
            {
                Session["Usuario"] = null;
                Session["Usuario_fail"] = result;
            }

            String path = Request.UrlReferrer.LocalPath;            
            return Redirect(path);           
        }

        public ActionResult Logout() {
            Session["Usuario"] = null;
            String path = Request.UrlReferrer.LocalPath;
            return Redirect(path);                      
        }

        public ActionResult Search(){
            List<Ubigeo> ubigeos = null;
            List<CategoriaServicio> categorias = null;

            //Cargar ubigeo
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(alumnoRESTService);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ubigeosJson = reader.ReadToEnd();
            ubigeos = js.Deserialize<List<Ubigeo>>(ubigeosJson);               
            ICollection<SelectListItem> tipos= new List<SelectListItem>();
                
            foreach(Ubigeo ub in ubigeos){
               tipos.Add(new SelectListItem() { 
                   Text=ub.descripcion.ToString(),
                   Value = ub.codDist.ToString()
               });
            }
           TempData["Ubigeo"] = tipos;

           //Cargar Categoria
           req = (HttpWebRequest)WebRequest.Create(categoriaRESTService);
           req.Method = "GET";
           res = (HttpWebResponse)req.GetResponse();
           reader = new StreamReader(res.GetResponseStream());
           string categoriasJson = reader.ReadToEnd();
           categorias = js.Deserialize<List<CategoriaServicio>>(categoriasJson);
           ICollection<SelectListItem>  tiposCategorias= new List<SelectListItem>();

           foreach(CategoriaServicio cat in categorias){
               try
               {
                   tiposCategorias.Add(new SelectListItem()
                   {
                       Text = cat.nomCatServ,
                       Value = cat.codCatServ
                   });
               }
               catch {
               }
           }
           TempData["Categoria"] = tiposCategorias;
           return View(ubigeos);
     
        }

        public ActionResult BuscaPoint()
        {
            String ubigeo = string.Empty;
            String categoria = string.Empty;
            String nombre = string.Empty;
            try
            {
                if (Session["search_Ubigeo"] != null)
                {
                    ubigeo = Session["search_Ubigeo"].ToString();
                }
                if (Session["search_Categoria"] != null)
                {
                    categoria = Session["search_Categoria"].ToString();
                }
                if (Session["search_Nombre"] != null)
                {
                    nombre = Session["search_Nombre"].ToString();
                }

                String url = "http://localhost:2998/Empresas.svc/Empresas/" + ubigeo + "/15/" + categoria + "/22/03/" + nombre;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string ubigeosJson = reader.ReadToEnd();
                List<Empresa> empresas = js.Deserialize<List<Empresa>>(ubigeosJson);

                TempData["resultado"] = empresas;
                TempData["Categoria"] = categoria;

                if (Session["Usuario"] != null)
                {
                    TempData["usr"] = Session["Usuario"].ToString().Trim();
                }
                else
                {
                    TempData["usr"] = string.Empty;
                }

                try
                {
                    TempData["Contador"] = empresas.Count;
                }
                catch
                {
                    TempData["Contador"] = 0;
                }
            }
            catch
            {
            }                      

            return View();
        }

        [HttpPost]
        public ActionResult BuscaPoint(FormCollection formCollection)
        {
            String ubigeo = string.Empty;
            String categoria = string.Empty;
            String nombre = string.Empty;
            try
            {
                ubigeo = Convert.ToInt32(formCollection["cmbUbigeo"]).ToString();
                categoria = formCollection["cmbCategoria"].ToString();
                nombre = formCollection["txtBusca"].ToString();

                Session["search_Ubigeo"] = ubigeo;
                Session["search_Categoria"] = categoria;
                Session["search_Nombre"] = nombre;             
            }
            catch
            {                
                if (Session["search_Ubigeo"] != null)
                {
                    ubigeo = Session["search_Ubigeo"].ToString();
                }
                if (Session["search_Categoria"] != null)
                {
                    categoria = Session["search_Categoria"].ToString();
                }
                if (Session["search_Nombre"] != null)
                {
                    nombre = Session["search_Nombre"].ToString();
                }
            }            

            String url = "http://localhost:2998/Empresas.svc/Empresas/"+ubigeo+"/15/"+categoria+"/22/03/"+nombre; 
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ubigeosJson = reader.ReadToEnd();
            List<Empresa> empresas = js.Deserialize<List<Empresa>>(ubigeosJson);
            
            TempData["resultado"] = empresas;
            TempData["Categoria"] = categoria;

            if (Session["Usuario"] != null)
            {
                TempData["usr"] = Session["Usuario"].ToString().Trim();
            }
            else {
                TempData["usr"] = string.Empty;
            }


            try
            {
                TempData["Contador"] = empresas.Count;
            }
            catch {
                TempData["Contador"] = 0;
            }


            /*
                [WebInvoke(Method = "GET", UriTemplate = "Empresas/obtenerTerminoEmpresa/{area}", ResponseFormat = WebMessageFormat.Json)]
                List<Empresa> ObtenerTerminoEmpresa(string area);                         
            */

            //Buscar el mejor servicio para el termino indicado
           /* url = "http://localhost:2998/Empresas.svc/Empresas/obtenerTerminoEmpresa/" + nombre;
            Response.Write(url);

            return View();
            req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            res = (HttpWebResponse)req.GetResponse();
            reader = new StreamReader(res.GetResponseStream());
            ubigeosJson = reader.ReadToEnd();
            empresas = js.Deserialize<List<Empresa>>(ubigeosJson);

            string lstStr = string.Empty;
            foreach(Empresa emp in empresas){
                lstStr = emp.codEmpresa + ",";
            }
            lstStr = lstStr.Substring(0,lstStr.Length - 1);

            PuntuacionWS.Service_PuntuacionesClient wspt = new PuntuacionWS.Service_PuntuacionesClient();
            Puntuacion pt = (Puntuacion) wspt.getBestEmpresa(lstStr);

            Empresa emps = new Empresa();
            foreach(Empresa emp in empresas){
                if(emp.codEmpresa.Equals(pt.idEmpresa)){
                    emps = emp; 
                }
            }

            TempData["bestEmpr"] = emps;
            TempData["bestPunt"] = pt;*/
            return View();
        }

        public ActionResult Registrar(){

            TempData["nombre"] = string.Empty;
            TempData["apellido"] = string.Empty;
            TempData["correo"] = string.Empty;
            TempData["usuario"] = string.Empty;
            TempData["edad"] = string.Empty;
            TempData["telefono"] = string.Empty;
            TempData["sexo"] = string.Empty;
            TempData["codDist"] = 15;

            List<Ubigeo> ubigeos = null;                     
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(alumnoRESTService);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ubigeosJson = reader.ReadToEnd();
            ubigeos = js.Deserialize<List<Ubigeo>>(ubigeosJson);
            ICollection<SelectListItem> tipos = new List<SelectListItem>();

            foreach (Ubigeo ub in ubigeos)
            {
                tipos.Add(new SelectListItem()
                {
                    Text = ub.descripcion.ToString(),
                    Value = ub.codDist.ToString()
                });
            }
            TempData["Ubigeo"] = tipos;
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(FormCollection formCollection)
        {

            List<Ubigeo> ubigeos = null;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(alumnoRESTService);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ubigeosJson = reader.ReadToEnd();
            ubigeos = js.Deserialize<List<Ubigeo>>(ubigeosJson);
            ICollection<SelectListItem> tipos = new List<SelectListItem>();

            foreach (Ubigeo ub in ubigeos)
            {
                tipos.Add(new SelectListItem()
                {
                    Text = ub.descripcion.ToString(),
                    Value = ub.codDist.ToString()
                });
            }
            TempData["Ubigeo"] = tipos;

            String result = string.Empty;
            String result_status = string.Empty;


            TempData["nombre"] = string.Empty;
            TempData["apellido"] = string.Empty;
            TempData["correo"] = string.Empty;
            TempData["usuario"] = string.Empty;
            TempData["edad"] = string.Empty;
            TempData["telefono"] = string.Empty;
            TempData["sexo"] = string.Empty;
            TempData["codDist"] = 15;

            try
            {
                String nombre = formCollection["txt_nombres"].ToString();                
                String apellido = formCollection["txt_apellidos"].ToString();
                String correo = formCollection["txt_email"].ToString();
                String usuario = formCollection["txt_usr"].ToString();
                String clave = formCollection["txt_pwd"].ToString();
                int edad = Convert.ToInt32(formCollection["txt_edad"].ToString());
                String telefono = formCollection["txt_telefono"].ToString();
                int sexo = Convert.ToInt32(formCollection["rb_sexo"].ToString());
                int codDist = Convert.ToInt32(formCollection["sel_distrito"].ToString());
                int codDpto = 15;                
                UsuarioWS.Service_UsuariosClient ws = new UsuarioWS.Service_UsuariosClient();
                result = ws.Ingresar_usuario(nombre, apellido, usuario, clave, telefono, correo, edad, sexo, codDist, codDpto);

                if (!(result.Equals("El usuario ha sido creado correctamente."))) {                 
                    result_status = "error";
                    TempData["nombre"] = nombre;
                    TempData["apellido"] = apellido;
                    TempData["correo"] = correo;
                    TempData["usuario"] = usuario;
                    TempData["edad"] = edad;
                    TempData["telefono"] = telefono;
                    TempData["sexo"] = sexo;
                    TempData["codDist"] = (codDist<10)?"0"+codDist.ToString():codDist.ToString();                    
                }
            }
            catch(Exception ex)
            {
                result = ex.Message.ToString();
                result_status="fail";
            }
            finally {
                Session["Register_result"] = result;
                Session["Register_result_status"] = result_status;
            }           
            return View();
        }
        
        public ActionResult Votar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostComment(FormCollection formCollection)
        {
            String hidEmpresa = string.Empty;
            String hidUsuario = string.Empty;
            String txtComentario = string.Empty;
            String txtExterno = string.Empty;
            String txtDireccion = string.Empty;
            String result = string.Empty;
            int puntuacion = 0;

            try
            {
                hidEmpresa = formCollection["hidEmpresa"].ToString();
                hidUsuario = formCollection["hidUsuario"].ToString();
                txtComentario = formCollection["txtComentario"].ToString();
                puntuacion = Convert.ToInt32(formCollection["numPuntuacion"]);
                txtExterno = formCollection["txtExterno"].ToString();
                txtDireccion = Request.ServerVariables.Get("REMOTE_ADDR").ToString();

                PuntuacionWS.Service_PuntuacionesClient ws = new PuntuacionWS.Service_PuntuacionesClient();
                result = ws.Ingresar_puntuacion_x_empresa(hidEmpresa, hidUsuario, txtComentario, puntuacion, txtExterno, txtDireccion);
                Response.Write(result);
            }
            catch(Exception ex) {
                Response.Write(ex.Message.ToString());
            }
            return View();
        }

        [HttpPost]
        public ActionResult getComment(FormCollection formCollection)
        {
            String hidEmpresa = string.Empty;
            try
            {
                hidEmpresa = formCollection["hidEmpresa"].ToString();
                
                PuntuacionWS.Service_PuntuacionesClient ws = new PuntuacionWS.Service_PuntuacionesClient();
                List<Puntuacion> lista =  ws.get_Comment_Empresa(hidEmpresa).ToList<Puntuacion>();
                TempData["lista"] = lista;
           }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
            return View();
        }

        [HttpGet]
        public ActionResult Votar(string emp, string usr)
        {            
            String codEmp = string.Empty;
            String codUsr = string.Empty;

            if (emp != null) 
            {
                codEmp = emp;
            }
            if (usr != null)
            {
                codUsr = usr;
            }
            
            if ((!codUsr.Equals(string.Empty)) && (!codEmp.Equals(string.Empty)))
            {
               // Response.Write("Ok vale todo");
            }

            TempData["codEmp"] = codEmp;
            TempData["codUsr"] = codUsr;

            try
            {                
                String url = "http://localhost:2998/Empresas.svc/Empresas/obtener/"+codEmp;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string ubigeosJson = reader.ReadToEnd();
                Empresa empresas = js.Deserialize<Empresa>(ubigeosJson);

                TempData["Empresa"] = empresas;
            }
            catch(Exception ex) {
                Response.Write(ex.Message.ToString());                
            }


            return View();
        }

    }
}
