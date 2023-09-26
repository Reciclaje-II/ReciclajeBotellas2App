let container = document.querySelectorAll(".modal-container")[0];
const modalNotificacion = document.getElementById('modalConfirmarDatosCampania');
const container_modal = document.getElementById('modalContainer');

function Open() {
    container.style.opacity = "1";
    container.style.visibility = "visible";
    modalNotificacion.classList.add('show');
    container_modal.style.pointerEvents = ("auto");
    modalNotificacion.style.transform = "translateY(0%)";
}
function Close() {
    container.style.opacity = "0";
    container.style.visibility = "hidden";
    container_modal.style.pointerEvents = ("none");
    modalNotificacion.classList.remove('show');
    modalNotificacion.style.transform = "translateY(-200%)";
}