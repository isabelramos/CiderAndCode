app.config(["$routeProvider",function($routeProvider) {
    $routeProvider
        .when("/pickapples",
            {
                templateUrl: "/app/views/PickApples/pickApples.html",
                controller: "pickApplesController"
        })
        .when("/listbushels",
            {
                templateUrl: "/app/views/ListBushels/listBushels.html",
                controller: "listBushelsController"
            });
}]);