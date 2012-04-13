using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionREST.Dominio;
using AplicacionREST.Persistencia;

namespace AplicacionREST
{    
    public class Catalogo : ICatalogo
    {
        private EmpresaDAO dao = new EmpresaDAO();

        public Empresa getBestService(string area)
        {
            return null;
        }
    }
}
