angular.module("MyApp").factory("myApp.contactService", function ($http) {
    return {
        getAll: function () {
            return $http.get("/GetContacts.html").then(function (res) {
                return res.data;
            });
        },

        update: function (contact) {
            return $http.post("/api/contact/Update", contact);
        }
    };
});
