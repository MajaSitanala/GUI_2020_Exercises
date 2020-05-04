
// Delopgave 01
let footerNode = document.getElementsByTagName('footer')[0];
let newHtml = "<p>This page was last modified on: " + document.lastModified + "</p>";
footerNode.innerHTML += newHtml;


// Delopgave 2
//let firstP = document.getElementById("content").firstElementChild;
//firstP.addEventListener("mouseover", function () {
//    ('[data-toggle="tooltip"]').tooltip()
//});


// Delopgave 03
let lady = document.getElementById("1");
lady.addEventListener("click", function (event) {
    event.preventDefault();                             // Undertrykker browserens default action ved klick på ancoret.
    let newWin = window.open(lady.href);                // Åbner nyt browser vindue.
});

let compas = document.getElementById("2");
compas.addEventListener("click", function (event) {
    let newWin = window.open(compas.href);
    setTimeout(closeWindow, 2000);                      // Tilføjer en timer som gør at billedet lukker efter 2 sekunder.
    event.preventDefault();
    function closeWindow() {
        newWin.close();
    }
});
