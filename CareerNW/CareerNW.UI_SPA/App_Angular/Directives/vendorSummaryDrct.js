(function () {

    var injectParams = ['careernwConstants'];

    var vendorSummary = function (careernwConstants) {

        return {
            restrict: 'E',
            templateUrl: careernwConstants.clientPath + '/App_Angular/Views/summary.html',
            controller: 'vendorSummaryCtrl',
            controllerAs: 'summaryVM'
        };
    };

    vendorSummary.$inject = injectParams;

    angular.module('careernw').directive('vendorSummary', vendorSummary);

}());