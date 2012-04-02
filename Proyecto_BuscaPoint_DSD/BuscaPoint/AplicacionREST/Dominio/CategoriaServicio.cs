using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionREST.Dominio
{
    [DataContract]
    public class CategoriaServicio
    {
        [DataMember]
        public string codCatServ { get; set; }
        [DataMember]
        public string nomCatServ { get; set; }
    }
}