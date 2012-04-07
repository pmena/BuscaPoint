using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionSOA.Dominio
{
    
    [DataContract]
    public class Puntuacion
    {
        [DataMember]
        public int idPuntuacion { get; set; }

        [DataMember]
        public string idUsuario { get; set; }

        [DataMember]
        public string idEmpresa { get; set; }

        [DataMember]
        public Double puntos { get; set; }
        
        [DataMember]
        public string fecha { get; set; }

        [DataMember]
        public string comentario { get; set; }

        [DataMember]
        public string direccion { get; set; }

        [DataMember]
        public string externo { get; set; }
    }
}