'use strict';
angular.module('careernwapp.Routes', ['ngRoute'])
    .config(function ($routeProvider) {

        var viewBase = '/CareerNW/App_Angular/Views/';

        $routeProvider
             .when('/home', {
                 controller: 'summaryCtrl',
                 templateUrl: viewBase + 'summary.html',
                 controllerAs: 'vm'
             })
            .otherwise({ redirectTo: '/home' })
    });