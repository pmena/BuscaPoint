using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionSOA.Dominio;
using NHibernate;

namespace AplicacionSOA.Persistencia
{
    public class UsuarioDAO : BaseDAO <Usuario,int>
    {

        public Boolean Login(string usuario, string clave)
        {
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Usuario>()
                        .Where(x => x.usuario == usuario)
                        .And(x => x.clave == clave);            
            if (queryOver.List().Count() == 1) {
                return true;
            }
            return false;
        }

        public Usuario Obtener(string usuario)
        {
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Usuario>()
                        .Where(x => x.usuario == usuario);
            if (queryOver.List().Count() >= 1)
            {
                return queryOver.List()[0];
            }
            return null;
        }

        public Boolean Existe(string usuario)
        {
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Usuario>()
                        .Where(x => x.usuario == usuario);
            if (queryOver.List().Count() >= 1)
            {
                return true;
            }
            return false;
        }
    }
}


