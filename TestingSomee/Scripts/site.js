$(document).ready(function(){
    //SCRIPT PARA LIMPIAR PROPAGANDA DE SOMEE.COM
    $("center").html("");

    //Evento Hover
    $("#homeCarousel").hover(function () {
         $(".CarouselItemDescription").css("opacity", "0.5");
         $(".CarouselItemDescription").css("transform", "translate(0px,0px)");
         $(".CarouselItemDescription").css("-o-transform", "translate(0px,0px)");
         $(".CarouselItemDescription").css("-moz-transform", "translate(0px,0px)");
         $(".CarouselItemDescription").css("-ms-transform", "translate(0px,0px)");
         $(".CarouselItemDescription").css("-webkit-transform", "translate(0px,0px)");
    }, function () {
        $(".CarouselItemDescription").css("opacity", "0");
        $(".CarouselItemDescription").css("transform", "translate(0px,100px)");
        $(".CarouselItemDescription").css("-o-transform", "translate(0px,100px)");
        $(".CarouselItemDescription").css("-ms-transform", "translate(0px,100px)");
        $(".CarouselItemDescription").css("-moz-transform", "translate(0px,100px)");
        $(".CarouselItemDescription").css("-webkit-transform", "translate(0px,100px)");


    })

})