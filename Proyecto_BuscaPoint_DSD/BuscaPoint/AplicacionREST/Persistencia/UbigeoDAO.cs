using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionREST.Dominio;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections;

namespace AplicacionREST.Persistencia
{
    public class UbigeoDAO
    {
        //Listado departamentos, provincias o distritos segun flag
        public List<Ubigeo> ObtenerListado(string tipoUbigeo, string codDpto, string codProv)
        {

            List<Ubigeo> listadoUbigeo = null;
            Ubigeo ubigeo = null;
            string sql = "";

            if (tipoUbigeo.Equals("0")) sql = "select * from dbo.tbl_ubigeo where codDist = '00' and codProv = '00'";
            if (tipoUbigeo.Equals("1")) sql = "select * from dbo.tbl_ubigeo where codDist = '00' and codProv <> '00' and codDpto= @codDpto";
            if (tipoUbigeo.Equals("2")) sql = "select * from dbo.tbl_ubigeo where codDist <> '00' and codDpto= @codDpto and codProv = @codProv";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    if (tipoUbigeo.Equals("1") || tipoUbigeo.Equals("2"))
                    {
                        com.Parameters.Add(new SqlParameter("@codDpto", codDpto));
                    }
                    if (tipoUbigeo.Equals("2"))
                    {
                        com.Parameters.Add(new SqlParameter("@codProv", codProv));
                    }
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            //Obtenemos uno por uno
                            listadoUbigeo = new List<Ubigeo>();
                            while (resultado.Read())
                            {
                                    //Recorremos objeto por objeto y añadimos    
                                    ubigeo = new Ubigeo()
                                    {
                                        codDpto = (string)resultado["codDpto"],
                                        codProv = (string)resultado["codProv"],
                                        codDist = (string)resultado["codDist"],
                                        descripcion = (string)resultado["descripcion"]
                                    };
                                    //Adicionamos al arreglo el objeto
                                    listadoUbigeo.Add(ubigeo);
                            }
                        }
                        else 
                        {
                            Debug.WriteLine("No retornó registros");                        
                        }
                    }
                }
            }
            return listadoUbigeo;
        }

    }
}