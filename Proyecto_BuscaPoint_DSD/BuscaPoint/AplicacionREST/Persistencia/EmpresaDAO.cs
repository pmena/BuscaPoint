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
    public class EmpresaDAO
    {
        //Listado de empresas segun filtro
        public List<Empresa> ObtenerListado(string tipoEmpresa, string codDpto, string codProv, string codDist, string codCatServ, string nomEmp)
        {
            List<Empresa> listadoEmpresas = null;
            Empresa empresa = null;
            string sql = "";

            if (tipoEmpresa.Equals("0")) sql = "select * from dbo.tbl_empresa emp inner join dbo.tbl_cat_servicio catServ on catServ.codCatServ = emp.codCatServicio where codDpto = @codDpto and codProv = @codProv and codDist = @codDist and codCatServicio = @codCatServ";
            if (tipoEmpresa.Equals("1")) sql = "select * from dbo.tbl_empresa emp inner join dbo.tbl_cat_servicio catServ on catServ.codCatServ = emp.codCatServicio where nomEmpresa LIKE '%' + @nomEmp + '%' ";
            if (tipoEmpresa.Equals("2")) sql = "select top 3 * from dbo.tbl_empresa where codCatServicio = @codCatServ order by fecIngreso desc, horIngreso desc";

            Debug.WriteLine("sql: " + sql);
            

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    if (tipoEmpresa.Equals("0"))
                    {
                        com.Parameters.Add(new SqlParameter("@codDpto", codDpto));
                        com.Parameters.Add(new SqlParameter("@codProv", codProv));
                        com.Parameters.Add(new SqlParameter("@codDist", codDist));
                        com.Parameters.Add(new SqlParameter("@codCatServ", codCatServ));
                    }
                    if (tipoEmpresa.Equals("1"))
                    {
                        com.Parameters.Add(new SqlParameter("@nomEmp", nomEmp));
                    }
                    if (tipoEmpresa.Equals("2"))
                    {
                        com.Parameters.Add(new SqlParameter("@codCatServ", codCatServ));
                    }

                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            //Obtenemos uno por uno
                            listadoEmpresas = new List<Empresa>();
                            while (resultado.Read())
                            {
                                //Recorremos objeto por objeto y añadimos    
                                empresa = new Empresa()
                                {
                                    codEmpresa = (string)resultado["codEmpresa"],        
                                    codDpto = (string)resultado["codDpto"],
                                    codProv = (string)resultado["codProv"],
                                    codDist = (string)resultado["codDist"],
                                    codCatServicio = (string)resultado["codCatServicio"],                                    
                                    desCatServicio = (string)resultado["nomCatServ"],
                                    nomEmpresa = (string)resultado["nomEmpresa"],
                                    desEmpP = (string)resultado["desEmpresaPeq"],
                                    desEmpG = (string)resultado["desEmpresaGen"],
                                    dirEmpr = (string)resultado["direccionEmp"],
                                    //desDpto = (string)resultado[""],
                                    //desProv = (string)resultado[""],
                                    //desDist = (string)resultado[""],
                                    telEmp1 = (string)resultado["telefonoEmp1"],
                                    telEmp2 = (string)resultado["telefonoEmp2"],
                                    celEmp1 = (string)resultado["celularEmp1"],
                                    celEmp2 = (string)resultado["celularEmp2"],
                                    faxEmpr = (string)resultado["faxEmpresa"],
                                    urlEmpr = (string)resultado["urlEmpresa"],
                                    codLatG = (string)resultado["codLatGoogle"],
                                    codAltG = (string)resultado["codAltGoogle"],
                                    codFcbk = (string)resultado["idFacebook"],
                                    fecIngE = (string)resultado["fecIngreso"],
                                    horFecE = (string)resultado["horIngreso"]
                                };
                                //Adicionamos al arreglo el objeto
                                listadoEmpresas.Add(empresa);
                            }
                        }
                        else
                        {
                            Debug.WriteLine("No retornó registros");
                        }
                    }
                }
            }
            return listadoEmpresas;
        }

    }
}