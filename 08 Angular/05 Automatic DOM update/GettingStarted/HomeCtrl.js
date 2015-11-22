angular.module("MyApp").controller("HomeCtrl", function ($scope) {
    $scope.data = 123;

    $scope.flag = true;

    $scope.names = [1, 2, 3];

    $scope.contacts = [
        { id: 1, name: "Ori" },
        { id: 2, name: "Roni" },
    ];

    $scope.run = function () {
        setTimeout(function () {

            $scope.$apply(function () {
                a();
                b();
                c();

                $scope.data = 12;
            });

        }, 1000);
    }

    $scope.change = function () {
        var html = '<span ng-show="blabla">Hidden section</span>';

        $("div[ng-controller=HomeCtrl]").append(html);

        $scope.names.push(4);
        $scope.names[1] = "XXX";

        $scope.contacts.push({ id: 3, name: "Udi" });
        $scope.contacts[1].name = "XXX";
    }
});

