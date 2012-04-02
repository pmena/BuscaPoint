using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionREST.Dominio;
using AplicacionREST.Persistencia;
using System.Diagnostics;
using System.Collections;

namespace AplicacionREST
{
    public class Empresas : IEmpresas
    {
        private EmpresaDAO dao = new EmpresaDAO();

        public List<Empresa> ObtenerListadoEmpresa(string tipoEmpresa, string codDpto, string codProv, string codDist, string codCatServ, string nomEmp) 
        {
            return dao.ObtenerListado(tipoEmpresa, codDpto, codProv, codDist, codCatServ, nomEmp);
        }

    }
}
