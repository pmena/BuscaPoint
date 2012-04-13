using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionSOA.Dominio;
using NHibernate;
using System.Data.SqlClient;

namespace AplicacionSOA.Persistencia
{
    public class PuntuacionDAO : BaseDAO <Puntuacion,int>
    {
        public Boolean Existe(string usuario, string empresa)
        {
            string fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Puntuacion>()
                        .Where(x => x.idUsuario == usuario)
                        .And(x => x.fecha == fecha).And(x => x.idEmpresa == empresa);
                        
            if (queryOver.List().Count() > 0)
            {
                return true;
            }
            return false;
        }

        public Boolean ExisteDireccion(string direccion, string empresa)
        {
            string fecha = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Puntuacion>()
                        .Where(x => x.direccion == direccion)
                        .And(x => x.fecha == fecha).And(x => x.idEmpresa == empresa);

            if (queryOver.List().Count() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Puntuacion> getCommentsEmpresa(string codEmpresa)
        {
            string fecha = DateTime.Now.Year + "-" + ((DateTime.Now.Month < 10) ? "0"+DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + DateTime.Now.Day;
            var queryOver = NHibernateHelper.ObtenerSesion().QueryOver<Puntuacion>()
                        .Where(x => x.idEmpresa == codEmpresa);                        

            if (queryOver.List().Count() > 0)
            {
                return queryOver.List().ToList();
            }
            return new List<Puntuacion>();
        }

        public Puntuacion getBestEmpresa(string lst)
        {            
            Puntuacion pt = null;
            string sql = string.Empty;
            
            sql = "SELECT top 1 IDEMPRESA empresa, SUM(puntos) puntos ";
            sql += "FROM BuscaPoint.dbo.PUNTUACION ";
            sql += "WHERE idEmpresa in (" + lst + ") ";
            sql += "GROUP BY IDEMPRESA ";
            sql += "ORDER BY puntos desc ";

            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {                                
                                pt = new Puntuacion()
                                {
                                    idEmpresa = (string) resultado["empresa"],
                                    puntos = (int) resultado["puntos"]
                                };
                            }
                        }
                        return pt;
                    }
                }
            }
            
            return new Puntuacion();
        }
    }
}


