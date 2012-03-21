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
    public interface IService_Empresas
    {
        //Nombre de las operaciones que ofrecerá el servicio
        // TODO: Add your service operations here
        [OperationContract]
        String Consultar_listado_empresas(int codEmpresa, int codServicio, int flag, int codDist, int codProv, int codDpto, String direccion);

    }

}
