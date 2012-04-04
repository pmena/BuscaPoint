using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace AplicacionSOA.Persistencia
{
    public class BaseDAO<Entidad, Id>
    {
        public Entidad Crear(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Save(entidad);
                sesion.Flush();
            }
            return entidad;
        }
    }
}