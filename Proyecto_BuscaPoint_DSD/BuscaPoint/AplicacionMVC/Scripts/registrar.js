

function validar() {
    var txt_nombres = $("#txt_nombres").val();
    var txt_apellidos = $("#txt_apellidos").val();
    var txt_email = $("#txt_email").val();
    var txt_usr = $("#txt_usr").val();
    var txt_pwd = $("#txt_pwd").val();
    var txt_confirmar_pwd = $("#txt_confirmar_pwd").val();
    var txt_telefono = $("#txt_telefono").val();
    var rb_sexo = $("#rb_sexo").val();
    var sel_distrito = $("#sel_distrito option:selected").val();
    var rb_ubic = $("#rb_ubic").val();

    var message = "";
    $("#mensaje_error_registro").css("display", "none");
    $("#mensaje_error_registro").html("");

    if (txt_nombres == "") {
        message = "Debe ingresar el nombre.";
    } else if (!(/[A-Za-z ñÑ]{1,50}/.test(txt_nombres))) {
        message = "El nombre es inválido";
    } else if (txt_apellidos == "") {
        message = "Debe ingresar los apellidos.";
    } else if (!(/[A-Za-z ñÑ]{1,50}/.test(txt_apellidos))) {
        message = "Los apellidos son inválidos.";
    } else if (txt_email == "") {
        message = "Debe ingresar el correo.";
    } else if (!(/[A-Za-z ñÑ]{1,50}/.test(txt_email))) {
        message = "El correo es inválido.";
    } else if (txt_usr == "") {
        message = "Debe ingresar el usuario.";
    } else if (!(/[A-Za-z ñÑ]{1,50}/.test(txt_usr))) {
        message = "El usuario es inválido";
    } else if (txt_pwd == "") {
        message = "Debe ingresar la contraseña.";
    } else if (!(/[A-Za-z ñÑ0-9]{1,50}/.test(txt_pwd))) {
        message = "La contraseña es inválida";
    } else if (txt_confirmar_pwd == "") {
        message = "Debe ingresar la contraseña.";
    } else if (!(/[A-Za-z ñÑ0-9]{1,50}/.test(txt_confirmar_pwd))) {
        message = "Confirme la contraseña";
    } else if (txt_telefono == "") {
        message = "Debe ingresar el teléfono.";
    } else if (!(/[0-9]{5,50}/.test(txt_telefono))) {
        message = "El teléfono es inválido";
    } else if (sel_distrito == "") {
        message = "Debe ingresar la ubicación inicial.";
    } else if (!(/[A-Za-z ñÑ0-9]{1,50}/.test(sel_distrito))) {
        message = "La ubicación inicial es inválida";
    }

    if (message != "") {
        $("#mensaje_error_registro").css("display", "inline");
        $("#mensaje_error_registro").html("<div class='alert alert-error'><h4 class='alert-heading'>Oh my Good!</h4><a class='close' data-dismiss='alert'>×</a>" + message + "</div> ");
        $(".close").click(function () {
            $(this).parent().remove();
        });
    } else {
        $("#mensaje_error_registro").css("display", "none");
        return true;
    }

    return false;
}

$(document).ready(function () {    
    $("#frm_registrar").submit(function () {
        if (validar()) {
            return true;
        }
        return false;
    });

    $(".close").click(function () {
        $(this).parent().remove();
    });
});