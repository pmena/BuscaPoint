<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>   
    <script type='text/javascript' src='http://maps.google.com/maps/api/js?sensor=true'></script>
    <script src="/Scripts/buscapoint.js" type="text/javascript" language="javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


	<div class='centrar' id='container' name='container' style='display:none'>
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

<table width='100%' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
	<tr>
		<td width='40%' align='center'>
			<table width='98%' height='100%'  style='border-style:solid;border-color:black;border-width:1px' bgcolor='white'>
				<tr>
					<td align='center' width='100%' height='65px' >
						<table cellpading='0' cellspacing='0' width='100%' style='border-style:solid;border-color:#3333CC;;border-width:1px' cellpadding='0' cellspacing='0'>
							<tr>
								<td width='2%'>&nbsp;</td>
								<td colspan='2' style='font-family:"Verdana";font-size:14px;color:#3333CC;'>
									<b>Discoteca Arenas</b></a>
								</td>
							</tr>
							<tr>
								<td width='2%'>&nbsp;</td>
								<td width='30%' height='35px' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<b>Valoración</b></a>
								</td>
								<td width='68%' style='font-family:"Verdana";font-size:14px;color:#3333CC'>
									<img src='/img/stars.png'></img>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<hr>
						<table width='100%' bgcolor='#E7EBF2'>
							<tr>
								<td rowspan='5'>
									<a href='http://www.facebook.com/severus.girl' >
										<img src='/img/fuckencio_usr_pablo.jpg' border='0'>
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Fuckencio Pablo Mena</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;'>
									Excelente lugar! =D buen hueco para pasar el rato, harta gente...
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									Febrero 28 desde <a href='#???'>Discoteca Arenas</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;' >
									<img src='/img/fb_icon.jpg' border='0'> A 50 personas les gusta
								</td>
							</tr>
							<tr>
								<td align='right' colspan='2' height='20px' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;' style='font-family:"Verdana";font-size:10px;color:#3333CC;' >
									<b> 230 comentarios más ...</b>&nbsp;&nbsp;&nbsp;
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align='center' width='100%' >
						<table cellpading='0' cellspacing='0' bgcolor='#D8D8D8' width='100%' cellpadding='0' cellspacing='0'>
							<tr>
								<td width='2%'>&nbsp;</td>
								<td colspan='2' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<b>Discotecas</b> en Miraflores >> <b><font color='#FF6600'>20 resultados</font></b></a>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table cellpading='0' cellspacing='0' bgcolor='white' width='100%' class="tblResult">
							<tr>
								<td rowspan='5' width='40%' align='center'>
									<a href='http://sapporo.com.pe/' data-geo-lat="41.927568" data-geo-long="-87.705201" >
										<img src='/img/logo_1_disco_miraflores.jpg' border='0'>
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;font-color:#3333CC;'>
									<b>Karaoke Saporo</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;'>
									<i><b>Karaoke Bar & Boxes Privados ven a Saporo y descubre tu voz</b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Discoteca y Pub</b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
									Av. Benavides 509<br>
									Esq. con alcanfores. 3er piso<br>
									Fiesta Hotel & Casino<br>
									Miraflores
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table  cellpading='0' cellspacing='0' bgcolor='#F0F0F0' width='100%' class="tblResult">
							<tr>
								<td rowspan='5' width='40%' align='center' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<a href='http://sapporo.com.pe/' data-geo-lat="41.927568" data-geo-long="-87.705201" >
										Sin imagen
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;font-color:#3333CC;'>
									<b>Discoteca Arenas</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;'>
									<i><b>Discoteca caleta para trampear.. ya sabes que hacer!</b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Discoteca y Pub</b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
									Av. Benavides 612<br>
									Miraflores
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table cellpading='0' cellspacing='0' bgcolor='white' width='100%' class="tblResult">
							<tr>
								<td rowspan='5' width='40%' align='center' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<a href='http://sapporo.com.pe/' data-geo-lat="41.921735" data-geo-long="-87.664688" >
										<img src='/img/logo_3_disco_miraflores.jpg' border='0'>
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;font-color:#3333CC;'>
									<b>Haus Karaoke Bar & Boxes</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;'>
									<i><b>Bar & Boxes</b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Discoteca y Pub</b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
									Av. José Pardo 534<br>
									Miraflores
								</td>
							</tr>
						</table>
					</td>
				<tr>
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table cellpading='0' cellspacing='0' bgcolor='white' width='100%' class="tblResult">
							<tr>
								<td rowspan='5' width='40%' align='center' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<a href='http://sapporo.com.pe/' data-geo-lat="41.927118" data-geo-long="-87.697621" >
										sin imagen
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;font-color:#3333CC;'>
									<b>Cohiba Club</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;'>
									<i><b>Espectáculos en vivo - Música Cubana</b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Discoteca y Pub</b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
									Av. Del ejército 453<br>
									Miraflores
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align='center' width='100%' style='border-top-style:solid;border-top-color:#3333CC;border-top-width:1px;'>
						<table cellpading='0' cellspacing='0' bgcolor='white' width='100%' >
							<tr>
								<td rowspan='5' width='40%' align='center' style='font-family:"Verdana";font-size:10px;color:#000000;'>
									<a href='http://sapporo.com.pe/' data-geo-lat="41.9786" data-geo-long="-87.9047" >
										sin imagen
									</a>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:12px;font-color:#3333CC;'>
									<b>Disco XYZ</b>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#787878;'>
									<i><b>Espectáculos en vivo - Música Afroamericana</b></i>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>Discoteca y Pub</b><br>
								</td>
							</tr>
							<tr>
								<td style='font-family:"Verdana";font-size:10px;color:#000000;'>
									Av. Del ejército 773<br>
									Miraflores
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>

            
		</td>
		<td width='60%' align='right'>
			<table width='800px' height='100%' style='border-style:solid;border-color:black;border-width:1px' bgcolor='white'>
				<tr>
					<td>
						<img src='/img/busqueda_map_hotels.jpg'>
					</td>
				</tr>

                <tr>
                    <td>
                         <div id="map_canvas"></div>
     
     <div id="more-info"><div>
     
        <h2>More Info</h2>
        <p>Hover over location on the left. (JavaScript must be enabled)</p>
     
     </div></div>

                    </td>
                </tr>
			</table>
		</td>
	</table>




</asp:Content>
