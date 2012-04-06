<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
        <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       <div class='centrar' id='container' name='container' style='display:none'>
		<div id='popup_buscar' style='z-index:333;background-color:#FFFF99;width:500px;height:300px;margin-left:-8px;margin-right:-305px;margin-top:-10px;margin-bottom:-10px;'>
			<form id='form_buscar' name='form_buscar' action='search'>
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


    <div id="bodyMain" class="container">
<table width='100%' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;' class="span12" >
	<tr>
		<td align='center'>
			<table style='border-style:dashed;' height='40px' width='100%' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
				<tr>
					<td align='center' width='30%' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;'>
						<b>!Lo más nuevo!&nbsp;</b>
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align='center' height='140px'  >
			<table height='100%' bgcolor='white'>
				<tr>
					<td ><a href='Home/search' ></a> <img src='/img/banner1.jpg' border='0' /></td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align='center' >
			<table style='border-style:dashed;' class="span10"  height='40px' cellpadding='0' cellspacing='0' style='margin-left:0px;margin-right:0px;margin-top:0px;margin-bottom:0px;'>
				<tr>
					<td align='center' style='font-family:"Verdana";font-size:10px;font-color:#3333CC'>
						<input type='button' id='btn_1' name='btn_1' value='  1  ' size='15'>&nbsp;
						<input type='button' id='btn_2' name='btn_2' value='  2  ' size='15'>&nbsp;
						<input type='button' id='btn_3' name='btn_3' value='  3  ' size='15'>&nbsp;
						<input type='button' id='btn_4' name='btn_4' value='  4  ' size='15'>&nbsp;
						<input type='button' id='btn_5' name='btn_5' value='  5  ' size='15'>&nbsp;
						<input type='button' id='btn_6' name='btn_6' value='  6  ' size='15'>&nbsp;
						<input type='button' id='btn_7' name='btn_7' value='  7  ' size='15'>&nbsp;
						<input type='button' id='btn_8' name='btn_8' value='  8  ' size='15'>&nbsp;
						<input type='button' id='btn_9' name='btn_9' value='  9  ' size='15'>&nbsp;
						<input type='button' id='btn_10' name='btn_10' value=' 10 ' size='15'>&nbsp;
						<input type='button' id='btn_11' name='btn_11' value=' 11 ' size='15'>&nbsp;
						<input type='button' id='btn_12' name='btn_12' value=' 12 ' size='15'>&nbsp;
						<input type='button' id='btn_13' name='btn_13' value=' 13 ' size='15'>&nbsp;
						<input type='button' id='btn_14' name='btn_14' value=' 14 ' size='15'>&nbsp;
						<input type='button' id='btn_15' name='btn_15' value=' 15 ' size='15'>&nbsp;
						<input type='button' id='btn_16' name='btn_16' value=' 16 ' size='15'>&nbsp;
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align='center' height='30px'  >
			<table width='800px' height='100%' >
				<tr>
					<td width='50%' style='font-family:"Verdana";font-size:12px;' ><b>Los más destacados </b></td>
					<td width='50%' style='font-family:"Verdana";font-size:14px;color:#3333CC;' align='right'>
						<b>¿Buscas un point?</b>
						<input type='button' id='btn_buscar' name='btn_buscar' value='Busca aquí' onclick="window.location='/Home/Search'">&nbsp;
					</td>
				</tr>
			</table>
		</td>
	</tr>
	<tr>
		<td align='center' >
			<table width='800px' height='100%' style='border-style:solid;border-color:black;border-width:1px'>
				<tr>
					<td align='center' style='font-family:"Verdana";font-size:14px;font-color:#3333CC;' >
						<table width='98%' bgcolor='white'>
							<tr>
								<td width='32%'>
									<table width='100%'>
										<tr>
											<td rowspan='5'>
												<a href='http://www.wasabi.com.pe' >
													<img src='/img/wasabi-logo1.png' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												<b>Restaurantes</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#FF6600;'>
												<b>Calificación: 4.5 de 5</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Tipo: Nikkei / Fusión
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla
												<br>..
												<a href='Home/BuscaPoint' >
													(ver mapa)
												</a>
											</td>
										</tr>
									</table>
								</td>
								<td width='2%'>
									&nbsp;
								<td/>
								<td width='32%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
									<table width='100%'>
										<tr>
											<td rowspan='5'>
												<a href='http://www.pioschicken.com.pe/' >
													<img src='/img/pios-chicken.jpg' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												<b>Restaurantes</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#FF6600;'>
												<b>Calificación: 4.0 de 5</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Tipo: Pollería
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla
												<br>..
												<a href='Home/BuscaPoint' >
													(ver mapa)
												</a>
											</td>
										</tr>
									</table>
								</td>
								<td width='2%'>
									&nbsp;
								<td/>
								<td width='32%' style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
									<table width='100%'>
										<tr>
											<td rowspan='5'>
												<a href='http://www.lamarcebicheria.com/web/intro.php' >
													<img src='/img/logo-la-mar.gif' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												<b>Restaurantes</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#FF6600;'>
												<b>Calificación: 4.5 de 5</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Tipo: Cebichería / Fusión
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;font-color:#3333CC;'>
												Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla
												<br>..
												<a href='Home/BuscaPoint' >
													(ver mapa)
												</a>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
						<table width='98%' bgcolor='white'>
							<tr>
								<td width='32%' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>16 Comentarios</b>&nbsp;<img src='/img/flecha-abajo-fb.png'></img>
									<hr>
									<table width='100%'>
										<tr>
											<td rowspan='4'>
												<a href='http://www.facebook.com/severus.girl' >
													<img src='/img/foto_usr1.jpg' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												<b>Karen Goytizolo</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;'>
												Que chévere el concepto del restaurante con videojuegos! Lo hace más entretenido! Un aplauso para eso!!! :D ya caeré pronto por ahí :3
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												Responder . <img src='/img/like-fb.png' border='0'>11 . Me gusta
											</td>
										</tr>
									</table>
									<hr>
								</td>
								<td width='2%'>
									&nbsp;
								</td>
								<td width='32%' width='32%' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>12 Comentarios</b>&nbsp;<img src='/img/flecha-abajo-fb.png'></img>
									<hr>
									<table width='100%'>
										<tr>
											<td rowspan='4'>
												<a href='http://www.facebook.com/severus.girl' >
													<img src='/img/foto_usr2.jpg' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												<b>Paul Gutierrez</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;'>
												¡Cuando sale nuevamente en El Especial del Humor? Ya me dió mucha hambre! jajajajaja ............
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												Responder . <img src='/img/like-fb.png' border='0'>11 . Me gusta
											</td>
										</tr>
									</table>
									<hr>
								</td>
								<td width='2%'>
									&nbsp;
								</td>
								<td width='32%' width='32%' style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
									<b>23 Comentarios</b>&nbsp;<img src='/img/flecha-abajo-fb.png'></img>
									<hr>
									<table width='100%'>
										<tr>
											<td rowspan='4'>
												<a href='http://www.facebook.com/severus.girl' >
													<img src='/img/foto_usr3.jpg' border='0'>
												</a>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												<b>Oscar Mejía</b>
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;'>
												blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
											</td>
										</tr>
										<tr>
											<td style='font-family:"Verdana";font-size:10px;color:#3333CC;'>
												Responder . <img src='/img/like-fb.png' border='0'>11 . Me gusta
											</td>
										</tr>
									</table>
									<hr>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</td>
	</tr>
</table>
</div>



</asp:Content>
