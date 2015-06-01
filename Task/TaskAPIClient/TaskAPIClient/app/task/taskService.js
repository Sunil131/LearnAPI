taskApp.factory('taskService', function ($http, $q) {
    return {
        getStringValue: function (minVal, maxVal, uri, headerVal) {
            return  $http({
                method: 'GET',
                url: uri + 'api/StringMaker',
                params: { minVal: minVal, maxVal: maxVal },
                headers: {
                    'x-caller': headerVal
                }
            }).then(function (response) {
                console.log(response.data);
                return response.data;
            }, function (response) {
                return $q.reject(response);
            });
        }
    }
});