angular.module("MyApp").factory("myApp.contactService", function ($http) {
    return {
        getAll: function () {
            return this.$http.get("/contacts.html").then(function (res) {
                return res.data;
            });
        },

        update: function (contact) {
            return this.$http.post("/api/contact/Update", contact);
        }
    };
});
