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
                Session["Usuario"] = txtUsuario.ToString();
                Session["Usuario_Posicion"] = ws.Get_Position_Usuario(txtUsuario.ToString());                
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

           //Cargar ubigeo
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
 

           return View(ubigeos);
     
        }

        public ActionResult BuscaPoint() {            
            return View();
        }

        public ActionResult Registrar(){
            UsuarioWS.Service_UsuariosClient ws = new UsuarioWS.Service_UsuariosClient();
            //String result = ws.
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(FormCollection formCollection)
        {
            String result = string.Empty;
            try
            {
                String nombre = formCollection["txt_nombres"].ToString();
                String apellido = formCollection["txt_apellidos"].ToString();
                String correo = formCollection["txt_email"].ToString();
                String usuario = formCollection["txt_usr"].ToString();
                String clave = formCollection["txt_pwd"].ToString();
                int edad = Convert.ToInt32(formCollection["txt_edad"].ToString());
                String telefono = string.Empty;
                int sexo = Convert.ToInt32(formCollection["rb_sexo"].ToString());
                int codDist = Convert.ToInt32(formCollection["sel_distrito"].ToString());
                int codDpto = 1;

                UsuarioWS.Service_UsuariosClient ws = new UsuarioWS.Service_UsuariosClient();
                result = ws.Ingresar_usuario(nombre, apellido, usuario, clave, telefono, correo, edad, sexo, codDist, codDpto);
            }
            catch(Exception ex)
            {
                result = ex.Message.ToString();
            }
            finally {
                Session["Register_result"] = result;
            }  
            //String path = Request.UrlReferrer.LocalPath;            
            return View();
        }

        //Referencia
/*        [HttpPost]
        public ActionResult Login(FormCollection formCollection) {
            //return Redirect("/");            
            foreach(string _formData in formCollection){
                Response.Write(">>> weee : "+_formData + " y value= "+ formCollection[_formData]);
            }
            
            return View();
        }*/
    }
}
