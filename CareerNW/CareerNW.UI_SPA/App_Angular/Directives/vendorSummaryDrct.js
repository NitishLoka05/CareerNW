(function () {

    var injectParams = [];

    var vendorSummary = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/summary.html',
            controller: 'summaryCtrl',
            controllerAs: 'summaryVM'
        };
    };

    vendorSummary.$inject = injectParams;

    angular.module('careernwapp').directive('vendorSummary', vendorSummary);

}());