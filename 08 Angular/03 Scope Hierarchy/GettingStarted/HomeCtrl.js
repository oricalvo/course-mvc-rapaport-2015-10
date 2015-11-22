/// <reference path="typings/angularjs/angular.d.ts" />

angular.module("MyApp").controller("HomeCtrl", function ($scope) {
    $scope.name = "parent";

    console.log("HomeCtrl created: " + this);

    this.message = "XXX";
});
