using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionSOAP.Dominio;
using NHibernate;

namespace AplicacionSOAP.Persistencia
{
    public class UsuarioDAO : BaseDAO <Usuario,int>
    {

        public int Login(string usuario, string clave)
        {
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Usuario>()
                        .Where(x => x.usuario == usuario)
                        .And(x => x.clave == clave);
            return queryOver.List().Count();
                        
        }
    }
}


