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
    public interface ICategoriaServicios
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "CategoriaServicios", ResponseFormat = WebMessageFormat.Json)]
        List<CategoriaServicio> ObtenerListadoCategoriaServicio();
    }
}
