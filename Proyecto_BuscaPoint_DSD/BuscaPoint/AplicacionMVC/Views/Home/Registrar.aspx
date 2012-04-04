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

<div class='centrar' id='container' name='container' style='display:none'>
		<div id='popup_ubicaciones' style='z-index:333;background-color:#FFFF99;width:650px;height:500px;margin-left:-10px;margin-right:-10px;margin-top:-10px;margin-bottom:-10px;'>
			<table width='100%'>
				<tr>
					<td colspan='3' height='25px' align='right'>
						<img src='/img/iconoCerrar.gif' onclick="javascript:document.all.container.style.display='none';">
					</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td colspan='3' height='25px' align='left' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
						<b>Mis ubicaciones:</b>
					</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td colspan='3' height='25px' align='justify' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						Personaliza tus ubicaciones, sobre los sitios que más frecuentes, para una mayor precisión en tu búsqueda.
					</td>
				</tr>
				<tr>
					<td colspan='3'>&nbsp;</td>
				</tr>
				<tr id='agregar_11' name='agregar_11'>
					<td width='2%'>&nbsp;</td>
					<td style='font-family:"Verdana";font-size:10px;color:#000000;' colspan='2'>
						<b>Agregar ubicación:</b>
					</td>
				</tr>
				<tr id='agregar_12' name='agregar_12'>
					<td width='2%'>&nbsp;</td>
					<td>
						<input type='text' name='txt_nomUbic1' id='txt_nomUbic1' value='Casa de mi abuela' size='26' style='font-family:"Verdana";font-size:10px;color:#000000;' >&nbsp;
						<select id='sel_tipo_dir' name='sel_tipo_dir' style='font-family:"Verdana";font-size:10px;color:#000000;'>
							<option value='Jr' selected>Jr.</option>
							<option value='Av'>Av.</option>
							<option value='Cl'>Cl.</option>
						</select>
						<input type='text' name='txt_dirUbic1' id='txt_dirUbic1' value='Cieza de Leon' size='35' style='font-family:"Verdana";font-size:10px;color:#000000;' >
						<input type='text' name='txt_dirNro1' id='txt_dirNro1' value='237' size='5' style='font-family:"Verdana";font-size:10px;color:#000000;' >
						<select name="sel_dist1" id="sel_dist1" style='font-family:"Verdana";font-size:10px;font-color:#3333CC;' />
							<option value=''>--- Distrito ---</option>
							<option value='1'>Cercado de Lima</option>
							<option value='3' selected>Ate</option>
							<option value='4'>Barranco</option>
							<option value='5'>Breña</option>
							<option value='7'>Comas</option>
							<option value='9'>Chorrillos</option>
							<option value='10'>El Agustino</option>
							<option value='11'>Jesús María</option>
							<option value='12'>La Molina</option>
							<option value='13'>La Victoria</option>
							<option value='14'>Lince</option>
							<option value='17'>Magdalena del Mar</option>
							<option value='18'>Miraflores</option>
							<option value='21'>Pueblo Libre</option>
							<option value='22'>Puente Piedra</option>
							<option value='25'>Rimac</option>
							<option value='27'>San Isidro</option>
							<option value='28'>Independencia</option>
							<option value='29'>San Juan de Miraflores</option>
							<option value='30'>San Luis</option>
							<option value='31'>San Martin de Porres</option>
							<option value='32'>San Miguel</option>
							<option value='33'>Santiago de Surco</option>
							<option value='34'>Surquillo</option>
							<option value='35'>Villa María del Triunfo</option>
							<option value='36'>San Juan de Lurigancho</option>
							<option value='38'>Santa Rosa</option>
							<option value='39'>Los Olivos</option>
							<option value='41'>San Borja</option>
							<option value='42'>Villa El Savador</option>
							<option value='43'>Santa Anita</option>
						</select>
					</td>
					<td>
						<img src='/img/Icono_check.gif'>
					</td>
				</tr>
				<tr>
					<td colspan='3'>&nbsp;</td>
				</tr>
				<tr id='agregar_21' name='agregar_21'>
					<td width='2%'>&nbsp;</td>
					<td style='font-family:"Verdana";font-size:10px;color:#000000;' colspan='2'>
						<b>Agregar ubicación:</b>
					</td>
				</tr>
				<tr id='agregar_22' name='agregar_22'>
					<td width='2%'>&nbsp;</td>
					<td>
						<input type='text' name='txt_nomUbic2' id='txt_nomUbic2' value='Nombre ubicación' size='26' style='font-family:"Verdana";font-size:10px;color:#000000;' >&nbsp;
						<select id='sel_tipo_dir' name='sel_tipo_dir' style='font-family:"Verdana";font-size:10px;color:#000000;'>
							<option value='Jr'>Jr.</option>
							<option value='Av'>Av.</option>
							<option value='Cl'>Cl.</option>
						</select>
						<input type='text' name='txt_dirUbic2' id='txt_dirUbic2' value='Dirección ubicación' size='35' style='font-family:"Verdana";font-size:10px;color:#000000;' >
						<input type='text' name='txt_dirNro2' id='txt_dirNro2' value='Nro.' size='5' style='font-family:"Verdana";font-size:10px;color:#000000;' >
						<select name="sel_dist2" id="sel_dist2" style='font-family:"Verdana";font-size:10px;font-color:#3333CC;' />
							<option value=''>--- Distrito ---</option>
							<option value='1'>Cercado de Lima</option>
							<option value='3'>Ate</option>
							<option value='4'>Barranco</option>
							<option value='5'>Breña</option>
							<option value='7'>Comas</option>
							<option value='9'>Chorrillos</option>
							<option value='10'>El Agustino</option>
							<option value='11'>Jesús María</option>
							<option value='12'>La Molina</option>
							<option value='13'>La Victoria</option>
							<option value='14'>Lince</option>
							<option value='17'>Magdalena del Mar</option>
							<option value='18'>Miraflores</option>
							<option value='21'>Pueblo Libre</option>
							<option value='22'>Puente Piedra</option>
							<option value='25'>Rimac</option>
							<option value='27'>San Isidro</option>
							<option value='28'>Independencia</option>
							<option value='29'>San Juan de Miraflores</option>
							<option value='30'>San Luis</option>
							<option value='31'>San Martin de Porres</option>
							<option value='32'>San Miguel</option>
							<option value='33'>Santiago de Surco</option>
							<option value='34'>Surquillo</option>
							<option value='35'>Villa María del Triunfo</option>
							<option value='36'>San Juan de Lurigancho</option>
							<option value='38'>Santa Rosa</option>
							<option value='39'>Los Olivos</option>
							<option value='41'>San Borja</option>
							<option value='42'>Villa El Savador</option>
							<option value='43'>Santa Anita</option>
						</select>
					</td>
					<td>
						<img src='/img/Icono_check.gif'>
					</td>
				</tr>
				<tr>
					<td colspan='3'>&nbsp;</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td colspan='3' style='font-family:"Verdana";font-size:10px;color:#3333CC;' valign='middle'>
					<img src='/img/add-icon.gif'></img>&nbsp;&nbsp;<b>Más ubicaciones .. </b>
					</td>
				</tr>
				<tr>
					<td colspan='3'>&nbsp;</td>
				</tr>
				<tr>
					<td colspan='3' align='center'>
						<input type='button' name='btn_cerrar' id='btn_cerrar' value='Guardar' onclick="javascript:document.all.container.style.display='none';">
					</td>
				</tr>
			</table>

		</div>
	</div>
<form id='frm_registrar' name='frm_registrar' action='Registrar' method="POST">
<table width='100%' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
	<tr>
		<td height='40px' cellpadding='0' cellspacing='0' align='center'>
			<table height='40px' width='100%' bgcolor='#FF6600' cellpadding='0' cellspacing='0'>
				<tr>
					<td width='20%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC'>
						&nbsp;
					</td>
					<td width='30%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
						<b>BuscaPoint&nbsp;<a href='index.htm'></b><img src="/img/icon_lupa1.gif" border="0"></a>
					</td>
					<td width='45%' style='font-family:"Verdana";font-size:14px;color:#3333CC'>
						<b>Registra tus datos</b>&nbsp;
						<img src='/img/icono-usuarios.gif'></img>
					</td>
					<td width='5%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC'>
						&nbsp;
					</td>
				</tr>
			</table>
		<td>
	</tr>
	<tr>
		<td align='center'>
			<table style='border-style:dashed;' width='800px' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
				<tr>
					<td align='left'>
					<table width='90%'>
						<tr>
							<td colspan="3">&nbsp;</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td colspan='3' height='35px' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
                                <% if (Session["Register_result"] != null) {  %>
                                        <b><font color='green'><% Response.Write(Session["Register_result"].ToString()); %></font></b>    
                                        <br /><br />
                                <%  Session["Register_result"] = null;
                                    } %>
								<div id='mensaje_ok_registro' style='display:none'>                                    															
								</div>
								<div id='mensaje_error_registro' style='display:none'>
									<b><font color='red'>Error en ingreso de datos.</font></b>
									<br><br>
								</div>
								<b>Información Personal:</b>
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
								<input type='text' id='txt_nombres' name='txt_nombres' value='' placeholder='Ingrese Nombres' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
								<input type='text' id='txt_apellidos' name='txt_apellidos' value='' placeholder='Ingrese Apellidos' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
      					<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
								<input type='text' id='txt_edad' name='txt_edad' value='' placeholder='Ingrese su edad' maxlength="3" size='40' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
								<input type='text' id='txt_email' name='txt_email' value='' placeholder='Ingrese Correo electrónico' size='40' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
								<input type='text' id='txt_usr' name='txt_usr' value='' placeholder='Ingrese Usuario' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>Contraseña:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								<input type='password' placeholder='Ingrese contraseña ' id='txt_pwd' name='txt_pwd' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>Confirmar Contraseña:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type='password' id='txt_confirmar_pwd' name='txt_confirmar_pwd' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;' placeholder='Confirme contraseña'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
								<input type='text' id='txt_telefono' placeholder='Ingrese teléfono' name='txt_telefono' value='' size='25' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>Sexo:</b>&nbsp;&nbsp;
								Masculino<input type='radio' id='rb_sexo' name='rb_sexo' value='1' checked>&nbsp;
								Femenino<input type='radio' id='rb_sexo' name='rb_sexo' value='2'>&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<!--
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>Foto de Perfil:</b>&nbsp;&nbsp;<input type='file' id='txt_foto' name='txt_foto'>
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						-->
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>Ubicación inicial:</b>&nbsp;&nbsp;
								<select name="sel_distrito" id="sel_distrito" style='font-family:"Verdana";font-size:10px;font-color:#3333CC;' />
                                    <% %>
								</select>
								&nbsp;<img v-align="bottom" src="/img/ico_ayuda.gif" alt="Esta es tu ubicación por defecto para búsqueda de establecimientos"></img>
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<b>¿Quieres configurar ubicaciones personalizadas?:</b>&nbsp;&nbsp;<br>
								No, gracias. Lo haré más tarde&nbsp;<input type='radio' id='rb_ubic' name='rb_ubic' value='1' checked>&nbsp;
								Sí&nbsp;<input type='radio' id='rb_ubic' name='rb_ubic' value='2' onclick="javascript:document.all.container.style.display='inline';">&nbsp;
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
						</tr>
						<tr>
							<td align='center' height='30px' width='2%' >
								&nbsp;
							</td>
							<td height='30px' width='48%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
								<input type='submit' id='btn_registrar' name='btn_registrar' value='Ingresa ya!'>
							</td>
							<td height='30px' width='50%' >
								&nbsp;
							</td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
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
