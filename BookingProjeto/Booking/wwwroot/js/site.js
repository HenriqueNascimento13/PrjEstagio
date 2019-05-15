// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MudarEstado(id) {
    var display = document.getElementById(id).style.display;
    if(display == "none")
        document.getElementById(id).style.display = 'block';
    else
        document.getElementById(id).style.display = 'none';
}

function enviarid(id) {
    var display = document.getElementById(id).style.display;
    if (display == "none")
        document.getElementById(id).style.display = 'block';
    else
        document.getElementById(id).style.display = 'none';
}

