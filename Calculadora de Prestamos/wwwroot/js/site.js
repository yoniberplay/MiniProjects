// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var x = document.getElementById("tipointeres");
document.getElementById("prue").value = x.value;
function myFunction() {
    var x = document.getElementById("tipointeres");
   
    if (x.selectedIndex >= 0) {
        var option = document.createElement("option");
        option.text = "Kiwi";
        var sel = x.options[x.selectedIndex];
        x.add(option, sel);
    }
}

var activities = document.getElementById("tipointeres");

activities.addEventListener("click", function () {
    document.getElementById("prue").value = x.value;
});

activities.addEventListener("change", function () {
    document.getElementById("prue").value = x.value;
});