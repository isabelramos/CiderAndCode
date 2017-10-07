app.controller("listBushelsController", ["$http", "$scope", function ($http, $scope) {
    $scope.bushelInfo = [];
    
    let getBushels = () => {
        $http.get("/api/bushels/list")
            .then((result) => {
                $scope.bushelInfo = result.data;
            }).catch((error) => {
                console.log("error", error);
            });
    };

    getBushels();


    $scope.deleteBushel = (id) => {
        $http.delete(`/api/bushels/${id}`)
            .then(() => {
                getBushels();
            }).catch((error) => {
                console.log("deleteBushel error", error);
            });
    };

}]);