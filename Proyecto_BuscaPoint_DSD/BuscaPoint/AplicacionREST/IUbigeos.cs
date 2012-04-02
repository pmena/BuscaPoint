using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionREST.Dominio;
using System.ServiceModel.Web;

namespace AplicacionREST
{
    [ServiceContract]
    public interface IUbigeos
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Ubigeos/{tipoUbigeo}/{codDpto}/{codProv}", ResponseFormat = WebMessageFormat.Json)]
        List<Ubigeo> ObtenerListadoUbigeo(string tipoUbigeo, string codDpto, string codProv);
    }
}
