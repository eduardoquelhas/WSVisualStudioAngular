//Criar o Module
var app = angular.module("ContatosApp", []);

//Registrar o Controller
app.controller("ContatosCtrl", function ($scope, $http) {  
    $http.get('WSContatos.asmx/ObterContatos')    
        .then(function (response) {
            $scope.contatos = response.data;
        });
});