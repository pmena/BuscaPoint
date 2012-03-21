using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Empresa" in code, svc and config file together.
    public class Empresas : IService_Empresas
    {

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public String Consultar_listado_empresas(int codEmpresa, int codServicio, int flag, int codDist, int codProv, int codDpto, String direccion)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

    }
}
