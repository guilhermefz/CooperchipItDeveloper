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

$(function () {
    $(".create").click(function (e) {
        e.preventDefault();

        $("#modalCid").load("/Cid/Create", function () {
            $("#modalCid").modal("show");
        });
    });

    $(".edit").click(function (e) {
        e.preventDefault();

        var linkUrl = $(this).attr("href");
        $("#modalCid").load(linkUrl, function () {
            $("#modalCid").modal("show");
        });
    });
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
