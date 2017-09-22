angular.module("coreMvcOne", [])
    .controller('indexController', function ($scope, $window, $http)
    {
        $scope.controllerScope = {
            MessageOne : "1-11-111",
            MessageTwo : "22-2222-22222222",
            MessageThree : "333",
        }

        $scope.FunctionOne = function () {
            $window.alert("called FunctionOne, woot.");
        }


        $scope.GetLeagues = function () {
            $window.alert("called OnGetLeagues, woot.");
            $http({
                method: 'GET', url: 'api/v1/league'
            }).then(function success(response) {
                $window.alert("wootier, succes.");
            }, function error(response) {
                $window.alert("no woot.");
            });
        }
});
