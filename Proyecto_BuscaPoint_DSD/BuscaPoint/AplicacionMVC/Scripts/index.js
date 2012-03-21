
$(document).ready(function () {
    $("#frmLogin").submit(function () {
        var txtUsuario = $("#txt_login");
        var txtPassword = $("#txt_clave");

        var valTxtUsuario = $.trim(txtUsuario.val());
        var valTxtPassword = $.trim(txtPassword.val());       

        $("#lblfrmLogin").html("&nbsp;");
        txtUsuario.css("border", "");
        txtPassword.css("border", "");
        txtUsuario.css("color", "");
        txtPassword.css("color", "");

        if (valTxtUsuario == "") {
            txtUsuario.css("border", "2px solid #3333CC");
            txtUsuario.css("color", "#3333CC");
            txtUsuario.focus();
            $("#lblfrmLogin").html("Corrija sus datos!");
        }

        if (valTxtPassword == "") {
            txtPassword.css("border", "2px solid #3333CC");
            txtPassword.css("color", "#3333CC");
            txtPassword.focus();
            $("#lblfrmLogin").html("Corrija sus datos!");
        }

        if ((valTxtUsuario != "") && (valTxtPassword != "")) {
            return true;
        }        
        return false;
    });
});