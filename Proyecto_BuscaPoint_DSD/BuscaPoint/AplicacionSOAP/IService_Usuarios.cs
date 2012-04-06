using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AplicacionSOA.Dominio;

namespace AplicacionSOA
{

    //Nombre del servicio pactado en el contrato
    [ServiceContract]
    public interface IService_Usuarios
    {
        //Nombre de las operaciones que ofrecerá el servicio
        // TODO: Add your service operations here
        [OperationContract]
        //Funcion que permite registrar un usuario de BuscaPoint
        String Ingresar_usuario(String nombre, String apellido, String usuario, String clave, String telefono, String correo, int edad, int sexo, int codDist, int codDpto);       
        
        //Funcion que permite a un usuario loguearse al sistema BuscaPoint
        [OperationContract]
        String Login_usuario(String usuario, String clave);

        //Funcion que permite obtener la posición de un usuario
        [OperationContract]
        Usuario Obtener_Usuario(String usuario);     
        
        //Funcion que permite editar datos de un usuario de BuscaPoint
        [OperationContract]
        String Editar_usuario(int codigo, String nombres, String apellidos, String email, String usuario, String clave, String telefono, Boolean sexo, int codDist, int codProv, int codDpto);

        //Funcion que lista los distritos de un departamento
        [OperationContract]
        String Listar_Distrito(int idDpto);                      
    }

}
