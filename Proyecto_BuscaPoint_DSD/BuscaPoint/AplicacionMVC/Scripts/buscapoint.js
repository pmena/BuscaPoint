
$(document).ready(function () {

    function goDestination(GoogleAlt, GoogleLat, zoo) {
        var latlng = new google.maps.LatLng(GoogleAlt, GoogleLat);
        var myOptions = {
            zoom: zoo,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        map = new google.maps.Map(document.getElementById("map_canvas"),
        myOptions);
    }

    var links = $(".result_business");

    links.click(function () {

        var enlace = $(this).find("table tbody tr:first").find("a");
        var gAlt = enlace.attr("data-geo-long");
        var gLat = enlace.attr("data-geo-lat");
        goDestination(gLat, gAlt, 16);
    });

    links.hover(function () {
        $(this).addClass("cHover");
    }, function () {
        $(this).removeClass("cHover");
    });

    $(".tblResult").hover(function () {
        $(this).addClass("cHover");
    }, function () {
        $(this).removeClass("cHover");
    });

    if (links.length > 0) {
        var padre = $(".tblResult");
        var nomEmpr = "";
        var descEmpr = "";

        nomEmpr = padre.find("tbody:first").find("tr:first").next(":first").find("td:first").text();
        dirEmpr = padre.find("tbody:first").find("tr:first").next().next().next().next().text();
        padre.parent().parent().parent().find("tr:first").click();        
        descEmpr = "";

        var lbl = $("#buscaPointLbl");
        lbl.removeClass();
        lbl.addClass("alert alert-info");
        lbl.html(" <strong>Empresa " + nomEmpr + "</strong>: Ubicación <span style='color:black;padding-right:5px;font-size:12px;font-weight:500;padding-top:3px;padding-bottom:1px;padding-left:2px;border:1px solid #bbb;background-color:white'>" + dirEmpr + "</span> ");
        lbl.append("<a class='close' data-dismiss='alert'>×</a>");

    } else {
        //Error no hay resultados,  mandarlo a una isla perdida
        goDestination(5.152418, 163.010276, 9);
        var lbl = $("#buscaPointLbl");
        lbl.removeClass();
        lbl.addClass("alert alert-error");
        lbl.html(" <strong>Oh my Good!</strong> Lo sentimos, el servicio que busca se encuentra en algún lugar del planeta. Cambie algunos términos e intentélo nuevamente...");
        lbl.append("<a class='close' data-dismiss='alert'>×</a>");
    }

    $(".close").click(function () {
        $(this).parent().remove();
    });
    $(".basic").jRating();
});


