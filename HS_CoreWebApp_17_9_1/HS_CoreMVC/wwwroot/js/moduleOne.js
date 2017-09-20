angular.module("coreMvcOne", [])
    .controller('indexController', function ($scope) {
    $scope.MessageOne = "1-11-111",
    $scope.MessageTwo = "22-2222-22222222",
    $scope.MessageThree = "333",
    $scope.FunctionOne = function () {
        window.alert("called FunctionOne, woot.");
    }
});
