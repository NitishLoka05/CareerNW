(function () {

    var injectParams = ['careernwConstants'];

    var vendorForm = function (careernwConstants) {

        return {
            restrict: 'E',
            templateUrl: careernwConstants.clientPath + '/App_Angular/Views/Partials/vendorForm.html'
        };
    };

    vendorForm.$inject = injectParams;

    angular.module('careernw').directive('vendorForm', vendorForm);

}());