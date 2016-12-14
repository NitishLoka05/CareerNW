(function () {

    var injectParams = [];

    var vendorCreate = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/create.html',
            controller: 'vendorCreateCtrl',
            controllerAs: 'createVM'
        };
    };

    vendorCreate.$inject = injectParams;

    angular.module('careernw').directive('vendorCreate', vendorCreate);

}());