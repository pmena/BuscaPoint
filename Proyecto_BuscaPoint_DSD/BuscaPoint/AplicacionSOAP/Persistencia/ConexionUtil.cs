using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSOA.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {            
            return "Data Source=.\\SQLEXPRESS;Initial Catalog=BuscaPoint;Integrated Security=SSPI;";
        }
    }
}