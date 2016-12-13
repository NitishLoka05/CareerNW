(function () {

    var injectParams = [];

    var vendorDetails = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/details.html',
            controller: 'detailsCtrl',
            controllerAs: 'detailsVM'
        };
    };

    vendorDetails.$inject = injectParams;

    angular.module('careernw').directive('vendorDetails', vendorDetails);

}());