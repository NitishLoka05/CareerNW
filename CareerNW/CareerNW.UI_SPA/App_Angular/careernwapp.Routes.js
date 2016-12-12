'use strict';
angular
    .module('careernwapp.Routes', ['ngRoute'])
    .config(function ($routeProvider) {

        var viewBase = 'http://localhost:64319/App_Angular/Views/';

        $routeProvider
             .when('/home', {
                 template: 'test your test'
                 //controller: 'summaryCtrl',
                 //templateUrl: '/App_Angular/Views/summary.html',
                 //controllerAs: 'vm'
             })
            .otherwise({ redirectTo: '/home' })
    });