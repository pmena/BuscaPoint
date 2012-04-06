<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>
    <script src="/Scripts/registrar.js" type="text/javascript" language="javascript"></script>

<style type="text/css">
	.centrar
	{
		position: absolute;
		/*nos posicionamos en el centro del navegador*/
		top:50%;
		left:50%;
		/*determinamos una anchura*/
		width:650px;
		/*indicamos que el margen izquierdo, es la mitad de la anchura*/
		margin-left:-300px;
		/*determinamos una altura*/
		height:500px;
		/*indicamos que el margen superior, es la mitad de la altura*/
		margin-top:-250px;
		border:2px solid #000000;
		padding:5px;
		/*indicamos color
		background-color:#FFFF99;
		/*priorizamos index
		z-index:auto;
	}
</style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<form id='frm_registrar' name='frm_registrar' action='Registrar' method="POST" class="container">
<table width='800px' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;' border='0'>
	<tr>
		<td align='left' nowrap="nowrap">
            &nbsp; <h3>Registra tus datos &nbsp; <img src='/img/icono-usuarios.gif' alt='Registro de usuarios' />			</h3>
		</td>
	</tr>
	<tr>
		<td align='center'>
			<table style='border-style:dashed;' width='800px' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
				<tr>
					<td align='left'>
					<table width='98%' border="0" cellpadding="3" cellspacing="0">
						<tr style="width:300px;">
							<td colspan="4">&nbsp;</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td colspan='3' style='font-family:Verdana;font-size:14px;color:#3333CC;'>
                                <% if ((Session["Register_result"] != null) && (Session["Register_result_status"] != "fail"))
                                   {  %>
                                        <b><font color='green'><% Response.Write(Session["Register_result"].ToString()); %></font></b>    
                                        <br /><br />
                                <%      Session["Register_result"] = null;
                                   } else if ((Session["Register_result"] != null) && (Session["Register_result_status"] == "fail")){ %>
                                       <div class="alert alert-error">
                                            <h4 class="alert-heading">Wtf!</h4>
                                            <a class="close" data-dismiss="alert">×</a>
                                            Ocurrió una excepción: <i><% Response.Write(Session["Register_result"].ToString()); %></i>
                                        </div>                                   
                                 <% } %>
								<div id='mensaje_ok_registro' style='display:none'>                                    															
								</div>
								<div id='mensaje_error_registro' style='display:none'>
									<b><font color='red'>Error en ingreso de datos.</font></b>									
								</div>								
							</td>
						</tr>
                        <tr>
                            <td></td>
                            <td colspan="2">
                                <h3>Información Personal</h3>
                            </td>
                            <td>
                            </td>
                        </tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
                            <td style='font-family:"Verdana";font-size:10px;color:#3333CC;' width="10%" nowrap="nowrap">
                                <strong>Nombres y Apellidos</strong>
                            </td>
                            <td>
                                <input type='text' id='txt_nombres' name='txt_nombres' value='' placeholder='Ingrese Nombres' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;'/>
								<input type='text' id='txt_apellidos' name='txt_apellidos' value='' placeholder='Ingrese Apellidos' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;'/>
                            </td>
							<td>
                            </td>
						</tr>
      					<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
                            <td style='font-family:"Verdana";font-size:10px;color:#3333CC;' nowrap="nowrap">
                                <strong>Edad</strong>
                            </td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
								<input type='text' id='txt_edad' name='txt_edad' value='' placeholder='Ingrese su edad' maxlength="3" size='40' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
                            <td style='font-family:"Verdana";font-size:10px;color:#3333CC;' nowrap="nowrap">
                                <strong>Correo electrónico</strong>
                            </td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
								<input type='text' id='txt_email' name='txt_email' value='' placeholder='Ingrese Correo electrónico' size='40' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>&nbsp;
							</td>
							<td>
                            </td>
						</tr>
                        <tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
                            <td height='30px'style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
								<strong>Teléfono</strong>
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
								<input type='text' id='txt_telefono' placeholder='Ingrese teléfono' name='txt_telefono' value='' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
                            <td style='font-family:"Verdana";font-size:10px;color:#3333CC;' nowrap="nowrap">
                                <strong>Usuario</strong>
                            </td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
								<input type='text' id='txt_usr' name='txt_usr' value='' placeholder='Ingrese Usuario' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;' />&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
								<b>Contraseña</b>
								
							</td>
                            <td height='30px' width='50%' >
								<input type='password' placeholder='Ingrese contraseña ' id='txt_pwd' name='txt_pwd' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' style='font-family:"Verdana";font-size:10px;color:#3333CC;' nowrap='nowrap'>
								<strong>Confirmar Contraseña</strong>
							</td>
                            <td height='30px' width='50%' >
								<input type='password' id='txt_confirmar_pwd' name='txt_confirmar_pwd' size='25' style='font-family:"Verdana";font-size:10px;color:#3333CC;' placeholder='Confirme contraseña'>&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
								<b>Sexo</b>
							</td>
                            <td height='30px' width='50%' >
								Masculino<input type='radio' id='rb_sexo' name='rb_sexo' value='1' checked>&nbsp;
								Femenino<input type='radio' id='rb_sexo' name='rb_sexo' value='2'>&nbsp;
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
								<b>Ubicación inicial</b>
							</td>
                            <td height='30px' width='50%' >
	    						<select name="sel_distrito" id="sel_distrito" style='font-family:"Verdana";font-size:10px;color:#3333CC;' />                          
								</select>
                                &nbsp;<img valign="bottom" style="display:none" src="/img/ico_ayuda.gif" alt="Esta es tu ubicación por defecto para búsqueda de establecimientos"></img>
							</td>
<td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px'  style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
								<b>¿Quieres configurar ubicaciones personalizadas?</b>								
							</td>
                            <td height='30px' width='50%' >
								Sí&nbsp;<input type='radio' id='Radio1' name='rb_ubic' value='2' onclick="javascript:document.all.container.style.display='inline';">&nbsp;
                                No, gracias. Lo haré más tarde&nbsp;<input type='radio' id='rb_ubic' name='rb_ubic' value='1' checked>&nbsp;
								
							</td>
<td>
                            </td>
						</tr>
						<tr>
                        <td>
                            </td>
							<td colspan="2">&nbsp;</td>
                            <td>
                            </td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' style='font-family:"Verdana";font-size:10px;color:#3333CC;' colspan='2'>
								<input type='submit' id='btn_registrar' name='btn_registrar' class="btn btn-primary" value='Ingresa ya!'>
                                <input type='reset' name='btn_registrar' class="btn" value='Limpiar formulario'>
							</td>
                            <td>
                            </td>
						</tr>
						<tr>
                        <td>
                            </td>
							<td colspan="2">&nbsp;</td>
                            <td>
                            </td>
						</tr>
					</table>
					</td>
				</tr>
			</table>
		</td>
	</tr>
</table>
</form>





</asp:Content>
