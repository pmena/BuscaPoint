$(function () {

    //var chicago = new google.maps.LatLng(41.924832, -87.697456),
    ///-12.108695914512028,-77.0124864578247
    var chicago = new google.maps.LatLng(-12.108695914512028, -77.0124864578247),

    
          pointToMoveTo,
          first = true,
          curMarker = new google.maps.Marker({}),
          $el;

    var myOptions = {
        zoom: 10,
        center: chicago,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    var map = new google.maps.Map($("#map_canvas")[0], myOptions);

    //$("#locations li").mouseenter(function () {
    $(".tblResult").mouseenter(function () {
        //alert($(this).find("tbody").find("tr:first").find("a").attr("data-geo-lat"));

        //$el = $(this);
        $el = $(this).find("tbody").find("tr:first").find("a");

        if (!$el.hasClass("hover")) {

            //$("#locations li").removeClass("hover");
            $(".tblResult").removeClass("hover");
            $el.addClass("hover");

            if (!first) {

                // Clear current marker
                curMarker.setMap();

                // Set zoom back to Chicago level
                // map.setZoom(10);
            }

            // Move (pan) map to new location
            pointToMoveTo = new google.maps.LatLng($el.attr("data-geo-lat"), $el.attr("data-geo-long"));
            map.panTo(pointToMoveTo);

            // Add new marker
            curMarker = new google.maps.Marker({
                position: pointToMoveTo,
                map: map,
                icon: "/img/marker.png"
            });

            // On click, zoom map
            google.maps.event.addListener(curMarker, 'click', function () {
                map.setZoom(14);
            });

            // Fill more info area
            $("#more-info")
            .find("h2")
              .html($el.find("h3").html())
              .end()
            .find("p")
              .html($el.find(".longdesc").html());

            // No longer the first time through (re: marker clearing)        
            first = false;
        }

    });

    //$("#location li:first").trigger("mouseenter");
    $(".tblResult :first").trigger("mouseenter");

});