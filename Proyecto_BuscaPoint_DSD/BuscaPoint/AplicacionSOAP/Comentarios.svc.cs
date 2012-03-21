using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Comentario" in code, svc and config file together.
    public class Comentarios : IService_Comentarios
    {

        //Obtener_comentarios_facebook
        public string Obtener_comentarios_facebook(int codEmpresaFB)
        {
            //return string.Format("You entered: {0}", value);
            return "Probando servicio por ahora";
        }

        //Funcion que permite ingresar comentarios facebook
        public string Ingresar_comentarios_facebook(int codEmpresa, String comentario, int codUsrFB)
        {
            //return string.Format("You entered: {0}", value);
            return "Probando servicio por ahora";
        }

    }
}
