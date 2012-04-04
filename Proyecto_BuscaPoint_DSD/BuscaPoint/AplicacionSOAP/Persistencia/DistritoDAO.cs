using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionSOA.Dominio;
using NHibernate;

namespace AplicacionSOA.Persistencia
{
    public class DistritoDAO : BaseDAO <Distrito,int>
    {
        public ICollection<Distrito> Listar_Distrito(int codigo)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion()) 
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(Distrito));
                return null;
            }
            /*var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Distrito>()
                        .Where(x => x.idDpto == codigo);
            return queryOver.List().ToList();*/
        }
    }
}


