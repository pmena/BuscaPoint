using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionSOA.Dominio;
using NHibernate;

namespace AplicacionSOA.Persistencia
{
    public class PuntuacionDAO : BaseDAO <Puntuacion,int>
    {
        public Boolean Existe(string usuario, string empresa)
        {
            string fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Puntuacion>()
                        .Where(x => x.idUsuario == usuario)
                        .And(x => x.fecha == fecha).And(x => x.idEmpresa == empresa);
                        
            if (queryOver.List().Count() > 0)
            {
                return true;
            }
            return false;
        }

        public Boolean ExisteDireccion(string direccion, string empresa)
        {
            string fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Puntuacion>()
                        .Where(x => x.direccion == direccion)
                        .And(x => x.fecha == fecha).And(x => x.idEmpresa == empresa);

            if (queryOver.List().Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}


