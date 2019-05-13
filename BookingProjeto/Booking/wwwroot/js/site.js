// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MudarEstado(estado) {
    var display = document.getElementById(estado).style.display;
    if(display == "none")
        document.getElementById(estado).style.display = 'block';
    else
        document.getElementById(estado).style.display = 'none';
}