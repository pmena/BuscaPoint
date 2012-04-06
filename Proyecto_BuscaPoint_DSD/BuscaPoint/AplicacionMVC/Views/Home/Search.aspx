<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <title>.:: BuscaPoint - Todos los sitios que necesites y más ::.</title>
    <script src="/Scripts/jquery.js" type="text/javascript" language="javascript"></script>
    <script src="/Scripts/search.js" type="text/javascript" language="javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<table width="80%" align="center" cellpadding="30" cellspacing="0" border="0">
<tr>
    <td align="center">
        <img alt="BuscaPoint" src="../../img/Buscapoint.png" />
    </td>
</tr>
<tr>
    <td align="center">
        <form method="POST" action="/Home/BuscaPoint" id="frmSearch" name="frmSearch">
            Buscar:
            <input type="text" id="txtBusca" name="txtBusca" class="input-medium search-query" value="" placeholder="Escribe el lugar a buscar" style="width:60%" />
            <br />
             <br/>Ubigeo <%: Html.DropDownList("cmbUbigeo", (IEnumerable<SelectListItem>)TempData["Ubigeo"]) %> 
             <br/>Categor&iacute;a <%: Html.DropDownList("cmbCategoria", (IEnumerable<SelectListItem>)TempData["Categoria"]) %>              
            <input type="submit" value="Buscar!" style="width:100px;">
        </form>
    </td>
</tr>

</table>

</asp:Content>
