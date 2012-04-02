using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionREST.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {
                return "Data Source=.\\SQLEXPRESS;Initial Catalog=ConsultoraInfoEmp;Integrated Security=SSPI;";
            }

        }
    }
}