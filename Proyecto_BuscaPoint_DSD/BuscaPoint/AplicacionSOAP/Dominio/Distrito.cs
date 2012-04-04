using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionSOA.Dominio
{
    [DataContract]
    public class Distrito
    {
        [DataMember]
        public string idDistrito { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int idDpto { get; set; }
    }
}