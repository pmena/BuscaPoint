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
    public class IService_EmpresaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Prueba de consulta de listado empresa via http POST
            //Listado por busqueda normal genérica (ubigeo + categoria servicio)
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Empresas.svc/Empresas/0/15/01/22/03/karaoke");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Empresa> empresaObtenida = js.Deserialize<List<Empresa>>(alumnoJson);
            Debug.WriteLine("Total listado empresas por busqueda generica: " + empresaObtenida.Count);
            Assert.IsNotNull(empresaObtenida);

            //Prueba de consulta de listado empresa via http POST
            //Listado de busqueda por nombre empresa
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Empresas.svc/Empresas/1/15/01/22/03/karaoke");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string alumnoJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            List<Empresa> empresaObtenida2 = js2.Deserialize<List<Empresa>>(alumnoJson2);
            Debug.WriteLine("Total listado empresas por busqueda nombre: " + empresaObtenida2.Count);
            Assert.IsNotNull(empresaObtenida2);

            //Prueba de consulta de listado empresa via http POST
            //Listado por busqueda top 3 lo mas nuevo (categoria servicio)
            HttpWebRequest req3 = (HttpWebRequest)WebRequest.Create("http://localhost:4598/Empresas.svc/Empresas/2/15/01/22/03/karaoke");
            req3.Method = "GET";
            HttpWebResponse res3 = (HttpWebResponse)req3.GetResponse();
            StreamReader reader3 = new StreamReader(res3.GetResponseStream());
            string alumnoJson3 = reader3.ReadToEnd();
            JavaScriptSerializer js3 = new JavaScriptSerializer();
            List<Empresa> empresaObtenida3 = js3.Deserialize<List<Empresa>>(alumnoJson3);
            Debug.WriteLine("Total listado empresas top 3 lo mas nuevo: " + empresaObtenida3.Count);
            Assert.IsNotNull(empresaObtenida3);

        }
    }
}
