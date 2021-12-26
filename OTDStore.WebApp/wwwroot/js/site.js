// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".slider-one")
    .not(".slick-initialized")
    .slick({
        autoplay: true,
        autoplaySpeed: 3000,
        dots: true,
        prevArrow: ".slide .slider-btn .prev",
        nextArrow: ".slide .slider-btn .next",
    });