$(document).on('click', '.details, .delete', function (e) {
    e.preventDefault();
    var $el = $(this);
    var id = $(this).data('id');

    if ($(this).hasClass('details')) {
        loadModal("/Cid/Details" + (id ? "?id=" + id : ""));
        return;
    }

    if ($el.hasClass('delete')) {
        if (!id) {
            alert('Erro: ID do item não encontrado.');
            return;
        }
        loadModal("/Cid/Delete?id=" + id);
    }
});

function loadModal(url) {
    $("#modalCid").load(url, function () {
        if (typeof $().modal === "function") {
            $("#modalCid").modal('show');
        } else {
            new bootstrap.Modal(document.getElementById('modalCid')).show();
        }
    });
}
