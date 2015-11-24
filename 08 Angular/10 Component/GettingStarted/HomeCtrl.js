(function () {

    function HomeCtrl($scope) {
        $scope.format = "HH:ss";

        $scope.onTick = function (time) {
            console.log("Tick: " + time);
        }

        $scope.stop = function () {
            $scope.clock1.stop();
        }
    }

    angular.module("MyApp").controller("HomeCtrl", 
        [
            "$scope",
            HomeCtrl
        ]);
})();
