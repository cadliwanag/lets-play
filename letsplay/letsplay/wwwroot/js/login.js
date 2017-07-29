// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {

    // Get the modal
    var modal = document.getElementById('id01');

    if (event.target == modal) {
        modal.style.display = "none";
    }
}