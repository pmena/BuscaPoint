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
    public class CategoriaServicioDAO
    {
        //Listado de categorias
        public List<CategoriaServicio> ObtenerListado()
        {
            List<CategoriaServicio> listadoCategoria = null;
            CategoriaServicio objCategoria = null;
            string sql = "select * from dbo.tbl_cat_servicio";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            //Obtenemos uno por uno
                            listadoCategoria = new List<CategoriaServicio>();
                            while (resultado.Read())
                            {
                                //Recorremos objeto por objeto y añadimos    
                                objCategoria = new CategoriaServicio()
                                {
                                    codCatServ = (string)resultado["codCatServ"],
                                    nomCatServ = (string)resultado["nomCatServ"]
                                };
                                //Adicionamos al arreglo el objeto
                                listadoCategoria.Add(objCategoria);
                            }
                        }
                        else
                        {
                            Debug.WriteLine("No retornó registros");
                        }
                    }
                }
            }
            return listadoCategoria;
        }

    }
}