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
    public class IService_CategoriaServicioTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Prueba de consulta de listado categoria servicio via http POST
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2998/CategoriaServicios.svc/CategoriaServicios");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<CategoriaServicio> catServObtenido = js.Deserialize<List<CategoriaServicio>>(alumnoJson);
            Debug.WriteLine("Total listado categorias: " + catServObtenido.Count);
            Assert.IsNotNull(catServObtenido);            
        }
    }
}
