using AplicacionSOA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using AplicacionSOAP.Dominio;

namespace AplicacionMVC.Tests
{
    
    
    /// <summary>
    ///This is a test class for IService_UsuarioTest and is intended
    ///to contain all IService_UsuarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IService_UsuarioTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual IService_Usuarios CreateIService_Usuario()
        {
            // TODO: Instantiate an appropriate concrete class.
            IService_Usuarios target = null;
            return target;
        }

        /// <summary>
        ///A test for Editar_usuario
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\upc\\AplicacionSOAP", "/")]
        [UrlToTest("http://localhost:2263/")]
        public void Editar_usuarioTest()
        {
            IService_Usuarios target = CreateIService_Usuario(); // TODO: Initialize to an appropriate value
            int codigo = 0; // TODO: Initialize to an appropriate value
            string nombres = string.Empty; // TODO: Initialize to an appropriate value
            string apellidos = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string usuario = string.Empty; // TODO: Initialize to an appropriate value
            string clave = string.Empty; // TODO: Initialize to an appropriate value
            string telefono = string.Empty; // TODO: Initialize to an appropriate value
            bool sexo = false; // TODO: Initialize to an appropriate value
            int codDist = 0; // TODO: Initialize to an appropriate value
            int codProv = 0; // TODO: Initialize to an appropriate value
            int codDpto = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Editar_usuario(codigo, nombres, apellidos, email, usuario, clave, telefono, sexo, codDist, codProv, codDpto);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get_Position_Usuario
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\upc\\AplicacionSOAP", "/")]
        [UrlToTest("http://localhost:2263/")]
        public void Get_Position_UsuarioTest()
        {
            IService_Usuarios target = CreateIService_Usuario(); // TODO: Initialize to an appropriate value
            string usuario = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Get_Position_Usuario(usuario);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Ingresar_usuario
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\upc\\AplicacionSOAP", "/")]
        [UrlToTest("http://localhost:2263/")]
        public void Ingresar_usuarioTest()
        {
            IService_Usuarios target = CreateIService_Usuario(); // TODO: Initialize to an appropriate value
            string nombre = string.Empty; // TODO: Initialize to an appropriate value
            string apellido = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string usuario = string.Empty; // TODO: Initialize to an appropriate value
            string correo = string.Empty; // TODO: Initialize to an appropriate value
            int edad =  0;
            string clave = string.Empty; // TODO: Initialize to an appropriate value
            string telefono = string.Empty; // TODO: Initialize to an appropriate value
            bool sexo = false; // TODO: Initialize to an appropriate value
            int codDist = 0; // TODO: Initialize to an appropriate value
            int codProv = 0; // TODO: Initialize to an appropriate value
            int codDpto = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            //Usuario actual;
            //actual = target.Ingresar_usuario(nombre, apellido, usuario, clave, telefono, correo, edad, sexo, codDist, codProv, codDpto);            
            String actual = null;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Login_usuario
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("E:\\upc\\AplicacionSOAP", "/")]
        [UrlToTest("http://localhost:2263/")]
        public void Login_usuarioTest()
        {
            IService_Usuarios target = CreateIService_Usuario(); // TODO: Initialize to an appropriate value
            string usuario = string.Empty; // TODO: Initialize to an appropriate value
            string clave = string.Empty; // TODO: Initialize to an appropriate value
            string expected = "0"; // TODO: Initialize to an appropriate value            
            string actual;
            actual = target.Login_usuario(usuario, clave);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
