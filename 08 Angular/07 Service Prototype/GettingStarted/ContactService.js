(function () {

    function ContactService($q, $http) {
        this.$q = $q;
        this.$http = $http;
    }

    ContactService.prototype.getAll = function () {
        //return this.$q.when([
        //    { "id": 1, "name": "Ori" },
        //    { "id": 2, "name": "Roni" }
        //]);

        return this.$http.get("/contacts.html").then(function (res) {
            return res.data;
        });
    }

    angular.module("MyApp").service("myApp.contactService", ContactService);
})();
