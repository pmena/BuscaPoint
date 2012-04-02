using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionREST.Dominio
{
    [DataContract]
    public class Empresa
    {
        [DataMember]
        public string codDpto { get; set; }
        [DataMember]
        public string codProv { get; set; }
        [DataMember]
        public string codDist { get; set; }
        [DataMember]
        public string codCatServicio { get; set; }
        [DataMember]
        public string desCatServicio { get; set; }
        [DataMember]
        public string nomEmpresa { get; set; }
        [DataMember]
        public string desEmpP { get; set; }
        [DataMember]
        public string desEmpG { get; set; }
        [DataMember]
        public string dirEmpr { get; set; }
        [DataMember]
        public string desDpto { get; set; }
        [DataMember]
        public string desProv { get; set; }
        [DataMember]
        public string desDist { get; set; }
        [DataMember]
        public string telEmp1 { get; set; }
        [DataMember]
        public string telEmp2 { get; set; }
        [DataMember]
        public string celEmp1 { get; set; }
        [DataMember]
        public string celEmp2 { get; set; }
        [DataMember]
        public string faxEmpr { get; set; }
        [DataMember]
        public string urlEmpr { get; set; }
        [DataMember]
        public string codLatG { get; set; }
        [DataMember]
        public string codAltG { get; set; }
        [DataMember]
        public string codFcbk { get; set; }
        [DataMember]
        public string fecIngE { get; set; }
        [DataMember]
        public string horFecE { get; set; }
    }
}