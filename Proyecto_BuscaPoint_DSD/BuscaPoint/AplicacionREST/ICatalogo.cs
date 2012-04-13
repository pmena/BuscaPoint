using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace AplicacionREST
{
 
    [ServiceContract]
    public interface ICatalogo
    {

      /*  [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Catalogo/getBestService/{area}", ResponseFormat = WebMessageFormat.Json)]
        Puntuacion setBestService(string area);*/
    }
}
