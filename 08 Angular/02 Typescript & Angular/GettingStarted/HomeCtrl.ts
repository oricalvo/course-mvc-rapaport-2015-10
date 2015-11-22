/// <reference path="typings/angularjs/angular.d.ts" />

(function () {
    
    class HomeCtrl {
        names: string[];
        name: string;

        constructor(private $http: ng.IHttpService) {
            this.names = [];

            this.loadDataFromServer();
        }

        private loadDataFromServer() {
            this.$http.get("/names.html").then((res) => {
                var contacts: Contact[] = <Contact[]>(res.data);
                this.names = contacts.map(function (contact) {
                    return contact.name;
                });
            }).catch(function () {
                alert("ERROR");
            });
        }

        add(name) {
            this.names.push(name);

            this.name = "";
        }
    }

    interface Contact {
        id: number;
        name: string;
    }

    angular.module("MyApp").controller("HomeCtrl", HomeCtrl);

})();
