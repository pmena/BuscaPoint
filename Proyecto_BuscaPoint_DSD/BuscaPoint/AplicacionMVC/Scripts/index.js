
$(document).ready(function () {
    $("#frmLogin").submit(function () {
        var txtUsuario = $("#txt_login");
        var txtPassword = $("#txt_clave");

        var valTxtUsuario = $.trim(txtUsuario.val());
        var valTxtPassword = $.trim(txtPassword.val());

        $("#frmLogin").find("label").each(function () {
            $(this).html("&nbsp;");
        });

        txtUsuario.css("border", "");
        txtPassword.css("border", "");
        txtUsuario.css("color", "");
        txtPassword.css("color", "");

        if (valTxtUsuario == "") {
            txtUsuario.css("border", "2px solid #FF0000");
            txtUsuario.css("color", "#FF0000");
            txtUsuario.focus();
            $("#lblfrmLogin").html("Corrija sus datos! &nbsp;");
        }

        if (valTxtPassword == "") {
            txtPassword.css("border", "2px solid red");
            txtPassword.css("color", "#FF0000");
            txtPassword.focus();
            $("#lblfrmLogin").html("Corrija sus datos! &nbsp;");
        }

        if ((valTxtUsuario != "") && (valTxtPassword != "")) {
            return true;
        }
        return false;
    });
});