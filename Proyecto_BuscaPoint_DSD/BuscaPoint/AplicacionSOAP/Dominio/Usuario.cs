using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionSOAP.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public string idUsuario { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellido { get; set; }
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string clave { get; set; }
        [DataMember]
        public int idDistrito { get; set; }
        [DataMember]
        public int idDpto { get; set; }
        [DataMember]
        public int edad { get; set; }
        [DataMember]
        public int sexo { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string correo { get; set; }
    }
}