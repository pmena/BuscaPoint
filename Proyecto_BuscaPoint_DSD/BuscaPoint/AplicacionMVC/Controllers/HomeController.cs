using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AplicacionMVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
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

            if (result.Equals("success"))
            {
                Session["Usuario"] = txtUsuario.ToString();
                Session["Usuario_Posicion"] = ws.Get_Position_Usuario(txtUsuario.ToString());
            }
            else
            {
                Session["Usuario"] = null;
            }

            String path = Request.UrlReferrer.LocalPath;            
            return Redirect(path);           
        }

        public ActionResult Logout() {
            Session["Usuario"] = null;
            String path = Request.UrlReferrer.LocalPath;
            return Redirect(path);                      
        }

        public ActionResult Search() {
            return View();        
        }

        public ActionResult BuscaPoint() {            
            return View();
        }

        public ActionResult Registrar(){
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(FormCollection formCollection)
        {            
            try
            {
                String nombre = formCollection["txt_nombres"].ToString();
                String apellido = formCollection["txt_apellidos"].ToString();
                String correo = formCollection["txt_correo"].ToString();
                String usuario = formCollection["txt_usr"].ToString();
                String clave = formCollection["txt_pwd"].ToString();
                String telefono = string.Empty;
                Boolean sexo = true;
                int codDist = 0;
                int codProv = 0;
                int codDpto = 0;

                UsuarioWS.Service_UsuariosClient ws = new UsuarioWS.Service_UsuariosClient();
               // XmlNode result = ws.Ingresar_usuario(nombre, apellido, usuario, clave, correo, telefono, sexo, codDist, codProv, codDpto);
            }
            catch { 
            
            
            }

            
            //XmlNode result = ws.Ingresar_usuario(nombre,apellido,correo,usuario,clave,telefono,sexo,codDist,codProv,codDpto);

            /*if
            {
                Session["Usuario"] = txtUsuario.ToString();
                Session["Usuario_Posicion"] = ws.Get_Position_Usuario(txtUsuario.ToString());
            }
            else
            {
                Session["Usuario"] = null;
            }*/

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
