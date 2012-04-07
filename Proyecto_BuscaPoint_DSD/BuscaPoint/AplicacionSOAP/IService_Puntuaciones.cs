using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AplicacionSOA
{

    //Nombre del servicio pactado en el contrato
    [ServiceContract]
    public interface IService_Puntuaciones
    {
        //Nombre de las operaciones que ofrecerá el servicio
        // TODO: Add your service operations here
        [OperationContract]
        //Funcion que permite registrar un usuario de BuscaPoint
        String Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario);

        //Funcion que permite a un usuario loguearse al sistema BuscaPoint
        [OperationContract]
        String Ingresar_puntuacion_x_empresa(string codEmpresa, string codUsuario, string comentario, int puntos, string externo, string direccion);

    }

}
