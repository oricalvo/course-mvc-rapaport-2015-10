/// <reference path="typings/angularjs/angular.d.ts" />

angular.module("MyApp").controller("ChildCtrl", function ($scope) {
    console.log("ChildCtrl created: " + this);
});
