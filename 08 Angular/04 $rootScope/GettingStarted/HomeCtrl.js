/// <reference path="typings/angularjs/angular.d.ts" />

function HomeCtrl($http, $scope, $rootScope) {
    $rootScope.userName = "XXX";
}

angular.module("MyApp").controller("HomeCtrl",HomeCtrl);
