﻿'use strict';
angular
    .module('careernw-routes', ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {

        var viewBase = 'http://localhost:64319/App_Angular/Views/';

        $routeProvider
             .when('/summary', {
                 template: '<vendor-summary></vendor-summary>'
                 //controller: 'summaryCtrl',
                 //templateUrl: viewBase + 'summary.html',
                 //controllerAs: 'summaryVM'
             })
             .when('/edit', {
                 template: '<vendor-edit></vendor-edit>'
                 //controller: 'detailsCtrl',
                 //templateUrl: viewBase + 'summary.html',
                 //controllerAs: 'summaryVM'
             })
             .when('/edit/5', {
                 template: '<vendor-edit></vendor-edit>'
                 //controller: 'detailsCtrl',
                 //templateUrl: viewBase + 'summary.html',
                 //controllerAs: 'summaryVM'
             })
            .otherwise({ redirectTo: '/summary' })

        //$locationProvider.html5Mode(true);
    });