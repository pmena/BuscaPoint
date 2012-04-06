using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using AplicacionREST.Dominio;


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
            }
            catch { 
                
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
            try
            {
                TempData["Contador"] = empresas.Count;
            }
            catch {
                TempData["Contador"] = 0;
            }

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
    }
}
