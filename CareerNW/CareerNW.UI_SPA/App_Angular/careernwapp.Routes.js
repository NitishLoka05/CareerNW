'use strict';
angular
    .module('careernwapp.Routes', ['ngRoute'])
    .config(function ($routeProvider) {

        var viewBase = 'http://localhost:64319/App_Angular/Views/';

        $routeProvider
             .when('/summary', {
                 template: '<vendor-summary></vendor-summary>'
                 //controller: 'summaryCtrl',
                 //templateUrl: viewBase + 'summary.html',
                 //controllerAs: 'summaryVM'
             })
             .when('/details', {
                 template: '<vendor-details></vendor-details>'
                 //controller: 'detailsCtrl',
                 //templateUrl: viewBase + 'summary.html',
                 //controllerAs: 'summaryVM'
             })
            .otherwise({ redirectTo: '/summary' })
    });