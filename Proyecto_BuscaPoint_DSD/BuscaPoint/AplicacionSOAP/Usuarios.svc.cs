using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AplicacionSOA.Persistencia;
using AplicacionSOA.Dominio;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Empresa" in code, svc and config file together.
    public class Usuarios : IService_Usuarios
    {

        private UsuarioDAO usuarioDAO = null;
        private UsuarioDAO UsuarioDAO
        {
            get
            {
                if (usuarioDAO == null)
                    usuarioDAO = new UsuarioDAO();
                return usuarioDAO;
            }
        }

        private DistritoDAO distritoDAO = null;
        private DistritoDAO DistritoDAO
        {
            get
            {
                if (distritoDAO == null)
                    distritoDAO = new DistritoDAO();
                return distritoDAO;
            }
        }

        //Funcion que permite registrar un usuario de BuscaPoint
        public String Ingresar_usuario(String nombre, String apellido, String usuario, String clave, String telefono, String correo, int edad, int sexo, int codDist, int codDpto)
        {
            Usuario usuarioACrear = new Usuario()
            {
                nombre = nombre,
                apellido = apellido,
                usuario = usuario,
                clave = clave,
                idDistrito = codDist,
                idDpto = codDpto,
                edad = edad,
                sexo = sexo,
                telefono = telefono,
                correo = correo                
            };
            if (UsuarioDAO.Existe(usuario)) {
                return "El usuario " + usuario + " ya existe en el sistema.";
            }else{            
                if (UsuarioDAO.Crear(usuarioACrear) != null)
                {
                    return "El usuario ha sido creado correctamente.";
                }
                else {
                    return "Lo sentimos, el servicio no esta disponible. Vuelva a intentarlo!";
                }     
            }
        }

        /**
         * @abstract Funcion que permite a un usuario loguearse al sistema BuscaPoint       
         * @param usuario Identificador de usuario
         * @clave clave Contraseña de usuario
         * @return String: True si el login es correcto, caso contrario false
         */
        public string Login_usuario(String usuario, String clave)
        {            
            return UsuarioDAO.Login(usuario, clave).ToString();      
        }

        //Funcion que obtiene la ubicación del usuario
        public Usuario Obtener_Usuario(String usuario)
        {       
            return UsuarioDAO.Obtener(usuario);
        }

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public string Editar_usuario(int codigo, String nombres, String apellidos, String email, String usuario, String clave, String telefono, Boolean sexo, int codDist, int codProv, int codDpto)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public string Listar_Distrito(int codigo)
        {            
            return distritoDAO.Listar_Distrito(codigo).ToString();
        }
    }
}
