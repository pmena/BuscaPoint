using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Diagnostics;
using AplicacionREST;
using AplicacionREST.Dominio;

namespace AplicacionMVC.Tests
{
    [TestClass]
    public class IService_UbigeoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Prueba de consulta de listado ubigeo (lista departamentos) via http POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Ubigeos.svc/Ubigeos/0/0/0");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Ubigeo> ubigeoObtenido = js.Deserialize<List<Ubigeo>>(alumnoJson);
            Debug.WriteLine("Total listado departamentos: " + ubigeoObtenido.Count);
            Assert.IsNotNull(ubigeoObtenido);

            //Prueba de consulta de listado ubigeo (lista provincias) via http POST
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Ubigeos.svc/Ubigeos/1/15/01");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string alumnoJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            List<Ubigeo> ubigeoObtenido2 = js2.Deserialize<List<Ubigeo>>(alumnoJson2);
            Debug.WriteLine("Total listado provincias: " + ubigeoObtenido2.Count);
            Assert.IsNotNull(ubigeoObtenido2);

            //Prueba de consulta de listado ubigeo (lista distritos) via http POST
            HttpWebRequest req3 = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Ubigeos.svc/Ubigeos/2/15/01");
            req3.Method = "GET";
            HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();
            StreamReader reader3 = new StreamReader(res3.GetResponseStream());
            string alumnoJson3 = reader3.ReadToEnd();
            JavaScriptSerializer js3 = new JavaScriptSerializer();
            List<Ubigeo> ubigeoObtenido3 = js3.Deserialize<List<Ubigeo>>(alumnoJson3);
            Debug.WriteLine("Total listado distritos: " + ubigeoObtenido3.Count);
            Assert.IsNotNull(ubigeoObtenido3);

        }

    }
}
