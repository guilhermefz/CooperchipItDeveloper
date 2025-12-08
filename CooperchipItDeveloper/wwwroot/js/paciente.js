$(document).on('click', '.delete, .details', function (e) {
    e.preventDefault();
    console.log("Clique capturado!");
    var $el = $(this);
    var id = $el.data('id');

    if ($(this).hasClass('details')) {
        loadModal("/Paciente/Details" + (id ? "?id=" + id : ""));
        return;
    }
    if ($el.hasClass('delete')) {
        if (!id) {
            alert('Erro: Id do item não encontrado.');
            return
        }
        loadModal("/Paciente/Delete" + (id ? "?id=" + id : ""));
    }
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



