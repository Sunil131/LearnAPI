var taskApp = angular.module('taskApp', ['ngRoute']);

taskApp.config(function ($routeProvider) {
    $routeProvider
    .when('/',
        {
            controller: 'stringController',
            templateUrl: '/app/task/taskView.html'
        }
    )
    .otherwise({redirectTo: '/'})
});

