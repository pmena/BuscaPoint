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
    public interface IEmpresas
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Empresas/{tipoEmpresa}/{codDpto}/{codProv}/{codDist}/{codCatServ}/{nomEmp}", ResponseFormat = WebMessageFormat.Json)]
        List<Empresa> ObtenerListadoEmpresa(string tipoEmpresa, string codDpto, string codProv, string codDist, string codCatServ, string nomEmp);
    }
}
