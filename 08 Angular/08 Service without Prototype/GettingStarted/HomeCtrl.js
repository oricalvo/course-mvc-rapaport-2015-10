(function () {

    function HomeCtrl(contactService, $scope) {
        contactService.getAll().then(function (contacts) {
            $scope.contacts = contacts;
        });
    }

    angular.module("MyApp").controller("HomeCtrl", 
        [
            "myApp.contactService",
            "$scope",
            HomeCtrl
        ]);
})();
