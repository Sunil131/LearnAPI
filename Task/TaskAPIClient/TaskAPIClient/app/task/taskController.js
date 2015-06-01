taskApp.controller('stringController', ['$scope', 'taskService', 'taskSettings', function stringController($scope, taskService, taskSettings) {

    $scope.stringDataVal = "";
    
    $scope.getMyString = function (isValid) {
        if (isValid) {
        //calling the service function
            taskService.getStringValue($scope.minValue, $scope.maxValue,
                taskSettings.ServiceURI, taskSettings.headerValue).
                then(function (data) {
                    $scope.stringDataVal = data;
                    $scope.error = ""
                }, function (response) {
                    $scope.stringDataVal = "";
                    $scope.error = "Unable to retrieve data. Please contact administrator";
                });
        };

    }

}]);