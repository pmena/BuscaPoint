
$(document).ready(function () {
    $("#frmSearch").submit(function () {
        var txtBusca = $("#txtBusca");
        var valTxtBusca = $("#txtBusca").val();
        valTxtBusca = $.trim(valTxtBusca);

        //Buscar siempre y cuando se ingrese algun dato
        if (valTxtBusca != "") {
            return true;
        }
        return false;
    });
});