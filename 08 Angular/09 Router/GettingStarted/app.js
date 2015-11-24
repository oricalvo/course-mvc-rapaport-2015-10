/// <reference path="angular.js" />

(function () {

    angular.module("MyApp", ["ui.router"])
        .config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

            //$locationProvider.html5Mode(true);

            $stateProvider
                .state('home', {
                    url: "/home",
                    templateUrl: "/Home.html",
                    controller: "HomeCtrl",
                })
                .state('home.contacts', {
                    url: "/contacts",
                    templateUrl: "/Contacts.html",
                })
                .state('home.groups', {
                    url: "/groups",
                    templateUrl: "/Groups.html",
                })
                .state('about', {
                    url: "/about",
                    templateUrl: "/About.html",
                    controller: "AboutCtrl",
                });

            $urlRouterProvider.otherwise("/home");
        })
        .run(function ($rootScope) {
            $rootScope.message = "YYY";
        });

})();
