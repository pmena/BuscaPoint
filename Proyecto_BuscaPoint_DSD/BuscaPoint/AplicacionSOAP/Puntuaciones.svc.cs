using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionSOA.Persistencia;
using AplicacionSOA.Dominio;
using System.Messaging;

namespace AplicacionSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Puntuacion" in code, svc and config file together.
    public class Puntuaciones : IService_Puntuaciones            
    {

        private PuntuacionDAO dao = new PuntuacionDAO();

        private string rutaCola = @".\private$\buscapoint";

        //Funcion que permite editar datos de un usuario de BuscaPoint
        public String Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario)
        {
            //return string.Format("You entered: {0}", value);
            return "... Mi nombre es Hetalia!";
        }

        //Funcion que permite obtener los comentarios de una empresa
        public List<Puntuacion> get_Comment_Empresa(string codEmpresa)
        {
            return dao.getCommentsEmpresa(codEmpresa);
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
                    /*if (dao.Crear(vo) != null)
                    {
                        return "Valoración registrado correctamente.";
                    }
                    else {
                        return "El servicio no esta disponible temporalmente. Intenteló más tarde.";
                    }*/
                }
            }
            else if (externo.Equals("N")) {
                if (dao.Existe(codUsuario, codEmpresa))
                {
                    return "Lo sentimos, se le esta permitido votar por esta empresa sólo una vez por día.";
                }
                else
                {
                    try
                    {
                        if (!MessageQueue.Exists(rutaCola))
                            MessageQueue.Create(rutaCola);
                        MessageQueue colaOut = new MessageQueue(rutaCola);
                        Message mensajeOut = new Message();
                        colaOut.Formatter = new XmlMessageFormatter(new Type[] { typeof(Puntuacion) });

                        mensajeOut.Label = "Valoracion-Comentario";
                        mensajeOut.Body = vo;
                        colaOut.Send(mensajeOut);

                        return "Valoración registrado correctamente.";
                    }
                    catch (Exception ex) {
                        return ex.Message.ToString();
                    }
                }
            }
            return "... Mi nombre es Hetalia!";
        }

        //Funcion que permite guardar datos de una puntuacion de BuscaPoint
        public void Tomar_puntuacion_x_empresa()
        {            
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue colaIn = new MessageQueue(rutaCola);
            colaIn.Formatter = new XmlMessageFormatter(new Type[] { typeof(Puntuacion) });
            
            while(colaIn.CanRead){
                Message mensajeIn = colaIn.Receive();
                Puntuacion vo = (Puntuacion)mensajeIn.Body;
            
                dao.Crear(vo);
            }
        }


        //Funcion que permite obtener la mejor puntuacion de un servicio
        public Puntuacion getBestEmpresa(string lst) 
        {
            return dao.getBestEmpresa(lst);
        }
    }
}
