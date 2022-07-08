function AjaxModal() {
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click", function (e)
            {
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                    keyboard: true
                                },
                                'show');
                            bindForm(this);
                        });
                    return false;
            });
        });

        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function BuscaCep() {
    $(document).ready(function () {
        function limpa_formulario_cep() {
            //limpa valores do formulário
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        //quando o campo cep perde o foco
        $("#Endereco_Cep").change(function () {

            //nova variável cep somente com dígitos
            var cep = $(this).val().replace(/\D/g, '');

            //verifica se campo cep possui valor informado
            if (cep != "") {

                var validacep = /^[0-9]{8}$/;

                //valida o formato do cep
                if (validacep.test(cep)) {

                    //preenche os campos com "..." enquanto consulta no webservice
                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                        if (!("erro" in dados)) {
                            //atualiza os campos com os valores da consulta
                            $("#Endereco_Logradouro").val(dados.logradouro);
                            $("#Endereco_Bairro").val(dados.bairro);
                            $("#Endereco_Cidade").val(dados.localidade);
                            $("#Endereco_Estado").val(dados.uf);
                        }
                        else {
                            //cep pesquisado não encontrado
                            limpa_formulario_cep();
                        }
                    });
                }
                else {
                    //cep inválido
                    limpa_formulario_cep();
                    alert("Formato de CEP inválido.");
                }
            }
            else {
                    //cep sem valor
                    limpa_formulario_cep();
            };
        });
    });
}

$(document).ready(function () {
    $("#msg_box").fadeOut(2500);
});