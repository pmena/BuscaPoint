using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AplicacionSOAP.Persistencia;
using AplicacionSOAP.Dominio;

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

        //Funcion que permite registrar un usuario de BuscaPoint
        public Usuario Ingresar_usuario(String nombre, String apellido, String usuario, String clave, String telefono, String correo, int edad, int sexo, int codDist, int codProv, int codDpto)
        {/*
            Usuario usuarioACrear = new Usuario()
            {
                nombre = nombre,
                apellido = apellido,
                usuario = usuario,
                clave = clave,
                idDistrito = codDist,
                idDpto = codProv,
                edad = edad,
                sexo = sexo,
                telefono = telefono,
                correo = correo                
            };
            return UsuarioDAO.Crear(usuarioACrear);*/
            return null;
        }

        //Funcion que permite a un usuario loguearse al sistema BuscaPoint
        public string Login_usuario(String usuario, String clave)
        {
            //return UsuarioDAO.Login(usuario, clave).ToString();
            return "success";
        }

        //Funcion que obtiene la ubicación del usuario
        public string Get_Position_Usuario(String usuario)
        {            
            return "Monterrico";
        }

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public string Editar_usuario(int codigo, String nombres, String apellidos, String email, String usuario, String clave, String telefono, Boolean sexo, int codDist, int codProv, int codDpto)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

    }
}
