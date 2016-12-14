(function () {

    var injectParams = [];

    var vendorForm = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/Partials/vendorForm.html'
        };
    };

    vendorForm.$inject = injectParams;

    angular.module('careernw').directive('vendorForm', vendorForm);

}());