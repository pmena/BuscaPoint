
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
            $("#lblfrmLogin").css("display", "");
            $("#lblfrmLogin").html("Corrija sus datos! &nbsp;");
            $("#lblfrmLogin").css("display", "inline");
        }

        if (valTxtPassword == "") {
            txtPassword.css("border", "2px solid red");
            txtPassword.css("color", "#FF0000");
            txtPassword.focus();
            $("#lblfrmLogin").css("display", "");
            $("#lblfrmLogin").html("Corrija sus datos! &nbsp;");
            $("#lblfrmLogin").css("display", "inline");
        }

        if ((valTxtUsuario != "") && (valTxtPassword != "")) {
            $("#lblfrmLogin").css("display", "none");
            return true;
        }

        if ($("#lblAuth").length > 0) {
            $("#lblAuth").html("");
            $("#lblAuth").remove();
        }

        $("#lblfrmLogin").parent().find("strong").remove();
        //alert($("#lblfrmLogin").parent().html());
        return false;
    });
});