using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionSOA.Persistencia;
using AplicacionSOA.Dominio;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Puntuacion" in code, svc and config file together.
    public class Puntuaciones : IService_Puntuaciones            
    {

        private PuntuacionDAO dao = new PuntuacionDAO();

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public String Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

        //Funcion que permite guardar datos de una puntuacion de BuscaPoint
        public String Ingresar_puntuacion_x_empresa(string codEmpresa, string codUsuario, string comentario, int puntos, string externo, string direccion)
        {
            string fecha= DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day;
            Puntuacion vo = new Puntuacion()
            {
                idEmpresa = codEmpresa,
                idUsuario = codUsuario,
                comentario = comentario,
                fecha = fecha,
                puntos = puntos,
                externo = externo,
                direccion = direccion                
            };

            if (externo.Equals("Y")) {
                if (dao.ExisteDireccion(direccion, codEmpresa))
                {
                    return "Lo sentimos, se le esta permitido votar por esta empresa sólo una vez por día.";
                }
                else {
                    if (dao.Crear(vo) != null)
                    {
                        return "Comentario registrado correctamente.";
                    }
                    else {
                        return "El servicio no esta disponible temporalmente. Intenteló más tarde.";
                    }
                }
            }
            else if (externo.Equals("N")) {
                if (dao.Existe(codUsuario, codEmpresa))
                {
                    return "Lo sentimos, se le esta permitido votar por esta empresa sólo una vez por día.";
                }
                else
                {
                    if (dao.Crear(vo) != null)
                    {
                        return "Comentario registrado correctamente.";
                    }
                    else
                    {
                        return "El servicio no esta disponible temporalmente. Intenteló más tarde.";
                    }
                }
            }
            return "... Mi nombre es Hetalia!";
        }

    }
}
