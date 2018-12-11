$(window).on('load', function(){
    $('#status').fadeOut();
    $('#preloader').delay(350).fadeOut('slow');

});

$(document).ready(function() {
    $("#team-members").owlCarousel({
        items:2,
        //autoplay:true,
        smartSpeed:700,
        loop:true,
        autoplayHoverPause:true,
        nav:true,
        dots:false,
        navText: ['<i class="fa fa-angle-left angle-icon"></i>','<i class="fa fa-angle-right angle-icon"></i>']
    });
})