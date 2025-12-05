$(document).on('click', '.details', function (e) {
    e.preventDefault();
    var $el = $(this);
    var id = $el.data('id');

        loadModal("/Paciente/Details" + (id ? "?id=" + id : ""));
    });

function loadModal(url) {
    $("#modalPaciente").load(url, function () {
        if (typeof $().modal === "function") {
            $("#modalPaciente").modal('show');
        } else {
            new bootstrap.Modal(document.getElementById('modalPaciente')).show();
        }
    });
}



