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
    public class CategoriaServicios : ICategoriaServicios
    {
        private CategoriaServicioDAO dao = new CategoriaServicioDAO();

        public List<CategoriaServicio> ObtenerListadoCategoriaServicio()
        {
            return dao.ObtenerListado();
        }

    }
}
