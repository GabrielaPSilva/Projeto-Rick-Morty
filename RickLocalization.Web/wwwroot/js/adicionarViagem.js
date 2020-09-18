$(function () {
    var $modalCadastrarViagem = $(".js-modal-cadastrar-viagem");

    $(".js-modal-viagem").on("click", function (e) {
        e.preventDefault();
        $modalCadastrarViagem.modal("show");
    });

    $(".js-modal-cancelar").on("click",
        function (e) {
            e.preventDefault();
            $modalCadastrarViagem.modal("hide");
        });

 });