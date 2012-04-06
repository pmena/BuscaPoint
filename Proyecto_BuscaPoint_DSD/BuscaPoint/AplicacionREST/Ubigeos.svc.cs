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
    public class Ubigeos : IUbigeos
    {
        private UbigeoDAO dao = new UbigeoDAO();

        public List<Ubigeo> ObtenerListadoUbigeo(string tipoUbigeo, string codDpto, string codProv) 
        {
            return dao.ObtenerListado(tipoUbigeo, codDpto, codProv);
        }

        public String ObtenerUbigeo(string codDpto, string codDistrito, string codProv)
        {
            return dao.ObtenerUbigeo(codDpto, codDpto, codProv);
        }

    }
}
