/// <reference path="typings/angularjs/angular.d.ts" />

function HomeCtrl($http, $scope, $rootScope) {
    $rootScope.userName = "XXX";
}
HomeCtrl.$inject = ["$http", "$scope", "$rootScope"];

angular.module("MyApp").controller("HomeCtrl",HomeCtrl);
