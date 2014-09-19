function empty() {
    if ((document.getElementById("txtUser").value == "") || (document.getElementById("txtPass").value == "")) {
        document.getElementById("lblError").innerHTML = "Por favor indique el nombre de usuario y contraseña";
        return false;
    }
    else {
        document.getElementById("lblError").innerHTML = "";
    }
}


function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;

}

function isNumberKeyComa(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57) && charCode != 44)
        return false;

    return true;

}