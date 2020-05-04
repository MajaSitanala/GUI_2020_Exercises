// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let obj = document.getElementsByClassName("menu");
for (i = 0; i < obj.length; i++) {
    obj[i].addEventListener("mouseover", function (event) {
        let target = event.target || event.srcElement;
        target.className = "menuEnhanced";
    });
    obj[i].addEventListener("mouseout", function (event) {
        let target = event.target || event.srcElement;
        target.className = "menu";
    });
}

