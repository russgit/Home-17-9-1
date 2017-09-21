angular.module("coreMvcOne", [])
    .controller('indexController', function ($scope, $window)
    {
        $scope.controllerScope = {
            MessageOne : "1-11-111",
            MessageTwo : "22-2222-22222222",
            MessageThree : "333",
        }

        $scope.FunctionOne = function () {
            $window.alert("called FunctionOne, woot.");
        }
});
