app.controller("listBushelsController", ["$http", "$scope", function ($http, $scope) {
    $scope.bushelInfo = [];

    $http.get("/api/bushels/list")
        .then(function (result) {
            $scope.bushelInfo = result.data;
        });

}]);