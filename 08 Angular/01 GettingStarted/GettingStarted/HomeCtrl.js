/// <reference path="angular.js" />

(function () {

    angular.module("MyApp").controller("HomeCtrl", function ($scope, $http) {

        $scope.names = [];

        $http.get("/names.html").then(function (res) {
            var contacts = res.data;
            $scope.names = contacts.map(function (contact) {
                return contact.name;
            });
        }).catch(function () {
            alert("ERROR");
        });

        $scope.add = function (name) {
            $scope.names.push(name);

            $scope.name = "";
        }
    });

})();
