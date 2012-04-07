﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionMVC.PuntuacionWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PuntuacionWS.IService_Puntuaciones")]
    public interface IService_Puntuaciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Puntuaciones/Obtener_puntuacion_x_empresa", ReplyAction="http://tempuri.org/IService_Puntuaciones/Obtener_puntuacion_x_empresaResponse")]
        string Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Puntuaciones/Ingresar_puntuacion_x_empresa", ReplyAction="http://tempuri.org/IService_Puntuaciones/Ingresar_puntuacion_x_empresaResponse")]
        string Ingresar_puntuacion_x_empresa(string codEmpresa, string codUsuario, string comentario, int puntos, string externo, string direccion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_PuntuacionesChannel : AplicacionMVC.PuntuacionWS.IService_Puntuaciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_PuntuacionesClient : System.ServiceModel.ClientBase<AplicacionMVC.PuntuacionWS.IService_Puntuaciones>, AplicacionMVC.PuntuacionWS.IService_Puntuaciones {
        
        public Service_PuntuacionesClient() {
        }
        
        public Service_PuntuacionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_PuntuacionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PuntuacionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PuntuacionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Obtener_puntuacion_x_empresa(int codEmpresa, int puntuacion, int usuario) {
            return base.Channel.Obtener_puntuacion_x_empresa(codEmpresa, puntuacion, usuario);
        }
        
        public string Ingresar_puntuacion_x_empresa(string codEmpresa, string codUsuario, string comentario, int puntos, string externo, string direccion) {
            return base.Channel.Ingresar_puntuacion_x_empresa(codEmpresa, codUsuario, comentario, puntos, externo, direccion);
        }
    }
}