/// <reference path="typings/angularjs/angular.d.ts" />
(function () {
    var HomeCtrl = (function () {
        function HomeCtrl($http) {
            this.$http = $http;
            this.names = [];
            this.loadDataFromServer();
        }
        HomeCtrl.prototype.loadDataFromServer = function () {
            var _this = this;
            this.$http.get("/names.html").then(function (res) {
                var contacts = (res.data);
                _this.names = contacts.map(function (contact) {
                    return contact.name;
                });
            }).catch(function () {
                alert("ERROR");
            });
        };
        HomeCtrl.prototype.add = function (name) {
            this.names.push(name);
            this.name = "";
        };
        return HomeCtrl;
    })();
    angular.module("MyApp").controller("HomeCtrl", HomeCtrl);
})();
//# sourceMappingURL=HomeCtrl.js.map