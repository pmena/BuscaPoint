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
    public interface IService_Comentarios
    {
        //Nombre de las operaciones que ofrecerá el servicio
        // TODO: Add your service operations here
        [OperationContract]
        //Funcion que permite registrar un usuario de BuscaPoint
        string Obtener_comentarios_facebook(int codEmpresaFB);

        //Funcion que permite a un usuario loguearse al sistema BuscaPoint
        [OperationContract]
        String Ingresar_comentarios_facebook(int codEmpresa, String comentario, int codUsrFB);

    }

}
