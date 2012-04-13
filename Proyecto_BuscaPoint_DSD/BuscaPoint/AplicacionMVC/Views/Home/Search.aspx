<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>
    <script src="/Scripts/search.js" type="text/javascript" language="javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p></p>
<table width="80%" align="center" cellpadding="30" cellspacing="10" border="0">
<tr>
    <td align="right" width="40%">
        <img alt="BuscaPoint" src="../../img/Buscapoint.png" width="500px" />
    </td>
    <td align="left">
        <form method="POST" action="/Home/BuscaPoint" id="frmSearch" name="frmSearch">            
            <h2 style="color:#3333CC">Que servicio busca?</h2>
            <input type="text" id="txtBusca" name="txtBusca" class="input-medium search-query" value="" placeholder="Escribe el nombre del servicio" style="width:60%" />
            <br />

             <h2 style="color:#3333CC">En que distrito?</h2>
             <%: Html.DropDownList("cmbUbigeo", (IEnumerable<SelectListItem>)TempData["Ubigeo"]) %> 
           
             <h2 style="color:#3333CC">Que categoría?</h2>
             <%: Html.DropDownList("cmbCategoria", (IEnumerable<SelectListItem>)TempData["Categoria"]) %>              
             <br />
            <input type="submit" class="btn btn-primary" value="Buscar!" style="width:100px;" />
        </form>
    </td>
</tr>

</table>

</asp:Content>
