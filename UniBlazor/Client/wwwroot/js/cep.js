var BlazorCEP = BlazorCEP || {};

BlazorCEP.setCEP = function (rua,bairro,cidade,estado, json) {
    var teste = JSON.parse(json)
    rua.value = teste.logradouro;
    bairro.value = teste.bairro;
    cidade.value = teste.localidade;
    estado.value = teste.uf
};

