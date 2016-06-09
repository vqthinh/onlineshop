/// <reference path="../plugins/angular/angular.js" />
var myAngular = angular.module("myAngular", []);
myAngular.controller("myController", myController);
myAngular.service("Validator", Validator);
myController.$inject = ['$scope','Validator'];


function myController($scope, Validator) {
    Validator.checkNumber(1);
}


function Validator($window) {
    return{
        checkNumber:checkNumber 
    }
    function checkNumber(input) {
        if(input%2===0) {
            $window.alert('Even');
        }
        else
        $window.alert('Odd');
    }
}