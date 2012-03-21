using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Puntuacion" in code, svc and config file together.
    public class Puntuaciones : IService_Puntuaciones
    {

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public String Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public String Ingresar_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

    }
}
