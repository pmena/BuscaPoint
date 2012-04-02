using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionREST.Dominio
{
    [DataContract]
    public class Ubigeo
    {
        [DataMember]
        public string codDpto { get; set; }
        [DataMember]
        public string codProv { get; set; }
        [DataMember]
        public string codDist { get; set; }
        [DataMember]
        public string descripcion { get; set; }
    }
}