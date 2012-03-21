using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSOAP.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=localhost;Initial Catalog=BuscaPoint;Integrated Security=SSPI;";
        }
    }
}