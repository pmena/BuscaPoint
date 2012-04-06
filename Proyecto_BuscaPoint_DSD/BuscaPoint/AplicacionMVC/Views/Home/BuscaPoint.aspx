<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <link rel="StyleSheet" href="/Content/jRating.jquery.css" type="text/css" />
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>   
    <script type='text/javascript' src='http://maps.google.com/maps/api/js?sensor=true'></script>
    <script src="/Scripts/buscapoint.js" type="text/javascript" language="javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">    
    <div class="container-fluid" >
        <div class="bpLeft">
            <div class="bpValoradoService">                
                <table width="100%" style="border:1px solid #bbb;background-color:White;margin:0px;height:100%;" cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="3">
                            <h3 style="color:#003366">&nbsp;  SERVICIO MEJOR VALORADO</h3>
                        </td>
                    </tr>
                    <tr>
                        <td rowspan="5" valign="middle" align="center" width="150px" nowrap="nowrap">
                            <img src="../../img/pios-chicken.jpg" alt="Pios Chicken" width="120px" />
                        </td>
                        <td nowrap="nowrap" style="background-color:white" colspan="2">
                            <h3 style="font-family:Georgia; color:#CC3333">PIOS CHICKEN</h3>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white" colspan="2">
                            <strong>Puntuación de Usuarios</strong>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white;width:130px">
                            <div class="basic" id="8_2"></div>            
                        </td>
                        <td><h3>7.5</h3></td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white" colspan="2">
                           <label style='color:#768696'> Total de votos: 9000</label>
                        </td>
                    </tr>
                     <tr>
                        <td nowrap="nowrap" style="background-color:white;height:5px" colspan="2">
                            &nbsp;                           
                        </td>
                    </tr>
                </table>                               
                
            </div>


            <div class="bpValoradoUser">                
                <table width="100%" style="border:1px solid #bbb;background-color:White;margin:0px;height:100%;" cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="3">
                            <h3 style="color:#003366">&nbsp; TOP COMMENTS</h3>
                        </td>
                    </tr>
                    <tr>
                        <td rowspan="6" valign="middle" align="center" width="150px" nowrap="nowrap">                            
                            <img border="0" alt="" src="/img/fuckencio_usr_pablo.jpg" style="width:120px" />
                        </td>
                        <td nowrap="nowrap" style="background-color:white">
                            <label class="bpUser">Fuckencio Pablo Mena</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color:white">
                            Excelente lugar! =D buen hueco para pasar el rato, harta gente...        
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white">
                           <i style='color:#003366'> Febrero 28 del 2012</i>
                        </td>
                    </tr>
                    <tr>
                        <td nowrap="nowrap" style="background-color:white" >
                           <img border="0" alt="" src="/img/fb_icon.jpg" style="position:relative;top:5px;left:-2px"> A 50 personas les gusta 

                        </td>
                    </tr>
                    <tr>
						<td align='right' colspan='2' height='15px' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;' style='font-family:"Verdana";font-size:10px;color:#3333CC;' >
									<b> 230 comentarios más ...</b>&nbsp;&nbsp;
								</td>
							</tr>
                    <tr style="height:5px">
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>                                           
            </div>

            <div class="bpValoradoEmpresa">                
                <table width="100%" style="border:1px solid #bbb;background-color:White;margin:0px;height:100%;" cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="3">
                            
                    		<table cellspacing='0' bgcolor='#D8D8D8' width='100%' cellpadding='0' cellspacing='0'>
					    		<tr>
						    		<td width='2%'>&nbsp;</td>
							    	<td colspan='2' style='font-family:"Verdana";font-size:10px;color:#000000;' nowrap="nowrap">
								    	<b>Discotecas</b> en Miraflores >> <b><font color='#FF6600'>
                                        Se encontraron 
                                        <% Response.Write(TempData["Contador"]);%>
                                        resultados</font></b>
		    						</td>
							    </tr>
						    </table>

                        </td>
                    </tr>

                    <tr>
                    <td colspan="3">

                    <div style="width: 100%; height: 400px; overflow: scroll; border: 2px dashed black; background-color: white;position:relative;left:-1px;">
                    <table width="100%" cellpadding="0" cellspacing="0">
                <% 
                    if (TempData["resultado"] != null)
                    {
                        foreach (AplicacionREST.Dominio.Empresa emp in (IEnumerable<AplicacionREST.Dominio.Empresa>)TempData["resultado"])
                        {  %>
				<tr class="result_business">
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table cellpadding='0' cellspacing='3' bgcolor='white' width='100%' class="tblResult" style="height:120px" >
							<tr>
								<td rowspan='5' width='40%' align='center' valign="middle">
<img src='/img/logo_1_disco_miraflores.jpg' alt='xxx' border='0' />
									<a href='http://<% Response.Write(emp.urlEmpr); %>' style="color:#003366" class="result_business_link" target="_blank" data-geo-lat="<% Response.Write(emp.codLatG); %>" data-geo-long="<% Response.Write(emp.codAltG); %>" >										
                                        Página Web
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;color:black;'>
									<b><% Response.Write(emp.nomEmpresa); %></b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;padding-right:5px'>
									<i><b>
                                        <% Response.Write(emp.desEmpP); %>
                                   </b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b><% Response.Write(emp.desCatServicio); %></b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
                                    <% Response.Write(emp.dirEmpr); %>
								</td>
							</tr>
						</table>
					</td>
				</tr>

                <% }
                    } %>
                    </table>
                    </div>

				</td>
                </tr>
                </table>                                           
            </div>

        </div>
        <div class="bpRight">
            <div id="buscaPointLbl" style="margin-bottom:3px;"></div>
            <div id="map_canvas" style="width:99%;min-height:700px;height:100%; border:4px solid white;background-color:#D8D8D8"></div>
        </div>
    </div>











	<div class='centrar' id='container' name='container' style="display:none">
		<div id='popup_buscar' style='z-index:333;background-color:#FFFF99;width:500px;height:300px;margin-left:-8px;margin-right:-305px;margin-top:-10px;margin-bottom:-10px;'>
			<form id='form_buscar' name='form_buscar' action='Home/search'>
			<table width='100%' >
				<tr>
					<td colspan='3' height='25px' align='right'>
						<img src='/img/iconoCerrar.gif' onclick="javascript:document.all.container.style.display='none';">
					</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td colspan='2' height='25px' align='left' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
						<b>Busca tu point:</b>
					</td>
				</tr>
				<tr>
					<td colspan='3' height='25px' align='right'>
						&nbsp;
					</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td height='25px' align='left' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						<b>Servicio:</b>
					</td>
					<td height='25px' align='left' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						<select id='sel_servicio' name='sel_servicio' style='font-family:"Verdana";font-size:10px'>
							<option value=''>-- Escoja servicio --</option>
							<option value='1'>Bares</option>
							<option value='2'>Bancos</option>
							<option value='3'>Bibliotecas</option>
							<option value='4'>Cajeros</option>
							<option value='5'>Centros de COnvenciones</option>
							<option value='6'>Cines</option>
							<option value='7'>Colegios</option>
							<option value='8'>Discotecas</option>
							<option value='9'>Entidades del Estado</option>
							<option value='10'>Gimnasios</option>
							<option value='11'>Hoteles</option>
							<option value='12'>Iglesias</option>
							<option value='13'>Museos</option>
							<option value='14'>Restaurantes</option>
							<option value='15'>Teatros</option>
							<option value='16'>Universidades</option>
						</select>
					</td>
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td height='25px' align='left' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						<b>Distrito:</b>
					</td>
					<td height='25px' align='left' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						<select name="sel_distBuscar" id="sel_distBuscar" style='font-family:"Verdana";font-size:10px;font-color:#3333CC;' />
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
				</tr>
				<tr>
					<td width='2%'>&nbsp;</td>
					<td height='25px' align='left' style='font-family:"Verdana";font-size:10px;color:#000000;'>
						<b>Dirección:</b>
					</td>
					<td height='25px' align='left' >
						<input type='text' id='txt_dir' name='txt_dir' size='70' style='font-family:"Verdana";font-size:10px;color:#000000;'>
					</td>
				</tr>
				<tr>
					<td colspan='3' height='25px' align='right'>
						&nbsp;
					</td>
				</tr>
				<tr>
					<td colspan='3' align='center'>
						<input type='submit' id='btn_buscar' name='btn_buscar' value='Buscar Points!'>
					</td>
				</tr>
			</table>
			</form>
		</div>
	</div>
   



</asp:Content>
