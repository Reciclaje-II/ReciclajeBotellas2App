function mostrarImagenLogo(input) {

    if (input.files && input.files[0]) {
        var file = input.files[0];
        var reader = new FileReader();

        if (file.type.match('image.*')) {
            reader.onload = function (e) {

                document.getElementsByClassName("imagenLogo")[0].setAttribute("src", e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
        else {
            alert("Solo se permiten archivos del tipo imagen válidos.");
        }
    }
}

function mostrarImagenDescripcion(input) {

    if (input.files && input.files[0]) {
        var file = input.files[0];
        var reader = new FileReader();

        if (file.type.match('image.*')) {
            reader.onload = function (e) {

                document.getElementsByClassName("imagenDescripcion")[0].setAttribute("src", e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
        else {
            alert("Solo se permiten archivos del tipo imagen válidos.");
        }
    }
}