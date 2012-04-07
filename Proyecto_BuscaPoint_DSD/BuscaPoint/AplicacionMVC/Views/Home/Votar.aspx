<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<html>
<head>
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <link rel="StyleSheet" href="/Content/Bootstrap.css" type="text/css" />
    <link rel="StyleSheet" href="/Content/jRating.jquery.css" type="text/css" />
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>   
    <script type="text/javascript" language="javascript">

        alert("aleeeeeeeeee2222222222");
        //$(document).ready(function () {

            function validarVotar() {
                var emp = $("#hidEmpresa");
                var usr = $("#hidUsuario");
                var com = $("#txtComentario");
                var obj = $("#VotarPrincipal");
                var divc = "<div id='valVotar' class='alert alert-error' style='margin-bottom:2px;'>";
                divc += "<strong>Oh my Good!</strong> Debe tener una empresa para valorar. No tiene asignado una. Intenteló más tarde.";
                divc += "<a class='close' data-dismiss='alert'>×</a>";
                divc += "</div>";

                $("#valVotar").remove();
                if (emp.val() == "") {
                    obj.before(divc);
                    return false;
                }

                return true;
            }

            alert("aleeeeeeeeee");
            $("#frmVotar").submit(function () {
                alert("suuuu");
                if (validarVotar()) {
                    $.ajax({
                        url: "/Home/PostComment",
                        dataType: "html",
                        data: {
                            hidEmpresa: $("#hidEmpresa").val(),
                            hidUsuario: $("#hidUsuario").val(),
                            txtComentario: $("#txComentario").text(),
                            numPuntuacion: 10,
                            txtExterno: "N"
                        },
                        success: function (rpta) {
                            var obj = $("#VotarPrincipal");
                            var divc = "";
                            if (rpta != "Comentario registrado correctamente.") {
                                divc = "<div id='valVotar' class='alert alert-error' style='margin-bottom:2px;'>";
                                divc += "<a class='close' data-dismiss='alert'>×</a>";
                                divc += "<strong>Oh my Good!</strong> " + rpta;
                                divc += "</div>";
                            } else {
                                divc = "<div id='valVotar' class='alert alert-success' style='margin-bottom:2px;'>";
                                divc += "<a class='close' data-dismiss='alert'>×</a>";
                                divc += "<strong>Felicidades!</strong> " + rpta;
                                divc += "Estamos redirigiendo en cincos segundos... ";
                                divc += "</div>";
                                setTimeout('window.location = "/Home/Buscapoint";', 5000);
                            }
                        }
                    });
                }
                return false;
            });

            $(".close").click(function () {
                $(this).parent().remove();
            });
            $(".basic").jRating();


        //});



    
    </script>

    </head>
    <body>
    <% if (TempData["codUsr"].Equals(string.Empty))
       {%>
            <div class="alert alert-error">
                <a class="close" data-dismiss="alert">×</a>
                <h4 class="alert-heading">Oh my Good!</h4>
                Debe loguearse antes de votar por una empresa.
            </div>
    <% } %>

    <% if (TempData["codEmp"].Equals(string.Empty))
       {%>
            <div class="alert alert-error">
                <a class="close" data-dismiss="alert">×</a>
                <h4 class="alert-heading">Oh my Good!</h4>
                Debe seleccionar una empresa para poder valorar su servicio.
            </div>
    <% } %>
   
    <div class="container-fluid" id="VotarPrincipal" >


        <% if (TempData["Empresa"] != null)               
           {
            AplicacionREST.Dominio.Empresa emp=(AplicacionREST.Dominio.Empresa)TempData["Empresa"];   
                %>
        <form method="POST" action="/Home/PostComment" id="frmVotar" name="frmVotar">
                <input type="hidden" id="hidEmpresa" name="hidEmpresa" value="<% Response.Write(TempData["codEmp"].ToString()); %>" /> 
                <input type="hidden" id="hidUsuario" name="hidUsuario" value="<% Response.Write(TempData["codUsr"].ToString()); %>" /> 

                <table width="800px" cellspacing="10" cellpadding="0" border="1" style="border:1px solid #bbb;background-color:White;margin:0px">                        
                    <tbody>
                    <tr>
                        <td style="width:350px;">     
                        
                            <table width="100%" cellspacing="0" cellpadding="5" bgcolor="#D8D8D8">
					    		<tbody><tr>
						    		<td width="2%">&nbsp;</td>
							    	<td nowrap="nowrap" style="font-family:Verdana;font-size:10px;color:#000000;" colspan="2">
                                        <b>VALORE EL SERVICIO!</b>								    	
		    						</td>
							    </tr>
						    </tbody></table>

                        </td>
                                               
                        <td>                                                                       
                            <table width="100%" cellspacing="0" cellpadding="5" bgcolor="#D8D8D8">
					    		<tbody><tr>
						    		<td width="2%">&nbsp;</td>
							    	<td nowrap="nowrap" style="font-family:Verdana;font-size:10px;color:#000000;" colspan="2">
                                        <b>COMENTENOS SOBRE EL SERVICIO</b>								    	
		    						</td>
							    </tr>
						    </tbody></table>
                             
                        </td>

                     </tr>

                      <tr>
                        <td valign="top" align="center">     
                        <table width="90%" cellspacing="0" cellpadding="5">
                        <tbody>
                                            <tr>
                        <td align="center" width="150px" valign="middle" nowrap="nowrap" rowspan="4">
                            <img width="120px" alt="Pios Chicken" src="../../img/pios-chicken.jpg" />
                        </td>
                        <td nowrap="nowrap" colspan="2" style="background-color:white">
                            <h3 style="font-family:Georgia; color:#CC3333"><% Response.Write(emp.nomEmpresa.ToUpper().Trim()); %></h3>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="background-color:white">
                            <i style="font-family:Georgia; color:#bbb"><% Response.Write(emp.desEmpP.Trim()); %></i>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white;width:130px">
                            <div id="div1" class="basic" style="height: 20px; width: 115px; overflow: hidden; z-index: 1; position: relative; cursor: default;"><div class="jRatingColor" style="width: 46px;"></div><div class="jRatingAverage" style="width: 0px; top: -20px;"></div><div class="jStar" style="width: 115px; height: 20px; top: -40px; background: url(&quot;/img/stars.png&quot;) repeat-x scroll 0% 0% transparent;"></div></div>            
                        </td>
                        <td valign="middle" align="left"><strong>7.5</strong></td>
                    </tr>
                   
                     <tr>
                        <td nowrap="nowrap" colspan="2" style="background-color:white;height:5px">
                            <span style="color:Red;">RUBRO: <% Response.Write(emp.desCatServicio.ToUpper().Trim()); %></span>     
                        </td>
                    </tr>

                     <tr>
                        <td colspan="3" style="background-color:white;height:5px">                            
                            Empresa ubicada en <strong ><% Response.Write(emp.dirEmpr.Trim()); %> <span style="color:red">(<% Response.Write(emp.desDist.ToUpper().Trim()); %>)</span></strong>     
                        </td>
                    </tr>                                       
                    
                     <tr>
                        <td colspan="3" style="background-color:white;height:5px">
                            <% Response.Write(emp.desEmpG.ToUpper().Trim()); %>     
                        </td>
                    </tr>
                    
                     <tr>
                        <td colspan="3" style="background-color:white;height:5px">
                                <ul>
                                    <li>Teléfonos fijos: <% Response.Write(emp.telEmp1.ToUpper().Trim()); %> / <% Response.Write(emp.telEmp2.ToUpper().Trim()); %> </li>
                                    <li>Celulares: <% Response.Write(emp.celEmp1.ToUpper().Trim()); %> / <% Response.Write(emp.celEmp2.ToUpper().Trim()); %> </li>
                                </ul>                                                            
                        </td>
                    </tr>

                                         <tr>
                        <td colspan="3" style="background-color:white;height:5px">
                            Siguelo en el Facebook por <strong style="color:navy"><% Response.Write(emp.idFace.Trim()); %></strong>.
                        </td>
                    </tr>

                    </tbody>
</table>

                        </td>
                                               
                        <td style="height:100%" valign="top" align="left">
                        
                            <textarea rows="5" name="txtComentario" id="txtComentario" cols="3" style="height:400px; width:98%;text-align:left;">El servicio brindado ...</textarea>
                                                                           
                        </td>

                     </tr>
                                         <tr>
                        <td nowrap="nowrap" colspan="2" style="background-color:white;">
                             <input type="submit" value="Votar!" id="Submit1" class="btn btn-primary" />
                             <input type="submit" value="Cancelar" class="btn" />
                        </td>                        
                    </tr>


                     </tbody></table>            
                  </form>
                  <% } else { %>


                  <% } %>

                  </div>





      </body>
      </html>