<%@ Page Language="C#"  Inherits="System.Web.Mvc.ViewPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />    
</head>

<body>
<% if (TempData["lista"] != null)      
   {       
       List<AplicacionMVC.PuntuacionWS.Puntuacion> lst = (List<AplicacionMVC.PuntuacionWS.Puntuacion>)TempData["lista"];
       if (lst.Count > 0)
       {
           foreach (AplicacionMVC.PuntuacionWS.Puntuacion pt in lst)
           {  %>
           <table border="0" width="100%" cellpadding="5" cellspacing="0" >
            <tr>
                <td rowspan="3" align="center" width="1%" valign="middle">
                    <img src="/img/pios-chicken.jpg"  width="100px" alt="<% Response.Write("xxx"); %>" />
                </td>
                 <td colspan="2">
                   <strong>Pablo Mena</strong>
                </td>
            </tr>
            <tr>
                <td align="left" width="10%" colspan="2">                    
                    <% Response.Write(pt.comentario); %> 
                </td>
            </tr>
            <tr>
                <td align="left" nowrap="nowrap" colspan="2">
                    <span class=" badge badge badge-info"><% Response.Write(pt.puntos); %> pts </span>
                    &nbsp;&nbsp;
                    <i style="color:#bbb">Realizado el <% Response.Write(pt.fecha); %>  </i>
                </td>
            </tr>

           </table>            
            <hr />
        
<%      }
       }
       else { %> 

    <div class="alert alert-info">    
    <strong>Registros: </strong> No hay comentarios para esta empresa.</div>      
       
<% } } %>     
</body>
</html>