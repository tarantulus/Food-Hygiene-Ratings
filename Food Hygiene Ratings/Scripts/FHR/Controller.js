FHR.controller('Controller', ['$scope', '$http', '$sce' , '$location',
    function ($scope, $http, $sce, $location) {

        $scope.error = null;
        $scope.businesses = [];
        var baseDomain = $location.protocol() + "://" + $location.host() + ":" + $location.port();
        console.log('getting Json from '+baseDomain);
        $http.get(baseDomain + '/Home/Data')
                        .success(function (data) {
                            angular.forEach(data, function (value, key) {                               
                                $scope.businesses.push(value);
                            })
                        })
                        .error(function (data, status, error, config) {
                            $scope.error = [{ heading: "Error", description: "Could not load json data" }];
                        });
    }]);