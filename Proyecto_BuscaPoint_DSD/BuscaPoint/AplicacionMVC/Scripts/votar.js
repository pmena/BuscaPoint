alert("aleeeeeeeeee2222222222");
$(document).ready(function () {

    function validarVotar() {
        var emp = $("#hidEmpresa");
        var usr = $("#hidUsuario");
        var com = $("#txtComentario");
        var obj = $("#VotarPrincipal");
        var divc = "<div id='valVotar' class='alert alert-error' style='margin-bottom:2px;'>";
        divc += "<strong>Oh my Good!</strong> Debe tener una empresa para valorar. No tiene asignado una. Intenteló más tarde.";
        divc += "<a class='close' data-dismiss='alert'>×</a>";
        divc += "</div>";

        $("#valVotar").remove();
        if (emp.val() == "") {
            obj.before(divc);
            return false;
        }

        return true;
    }

    alert("aleeeeeeeeee");
    $("#frmVotar").submit(function () {
        alert("suuuu");
        if (validarVotar()) {
            $.ajax({
                url: "/Home/PostComment",
                dataType: "html",
                data: {
                    hidEmpresa: $("#hidEmpresa").val(),
                    hidUsuario: $("#hidUsuario").val(),
                    txtComentario: $("#txComentario").text(),
                    numPuntuacion: 10,
                    txtExterno: "N"
                },
                success: function (rpta) {
                    var obj = $("#VotarPrincipal");
                    var divc = "";
                    if (rpta != "Comentario registrado correctamente.") {
                        divc = "<div id='valVotar' class='alert alert-error' style='margin-bottom:2px;'>";
                        divc += "<a class='close' data-dismiss='alert'>×</a>";
                        divc += "<strong>Oh my Good!</strong> " + rpta;
                        divc += "</div>";
                    } else {
                        divc = "<div id='valVotar' class='alert alert-success' style='margin-bottom:2px;'>";
                        divc += "<a class='close' data-dismiss='alert'>×</a>";
                        divc += "<strong>Felicidades!</strong> " + rpta;
                        divc += "Estamos redirigiendo en cincos segundos... ";
                        divc += "</div>";
                        setTimeout('window.location = "/Home/Buscapoint";', 5000);
                    }
                }
            });
        }
        return false;
    });

    $(".close").click(function () {
        $(this).parent().remove();
    });
    $(".basic").jRating();


});


