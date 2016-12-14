(function () {

    var injectParams = ['careernwConstants'];

    var vendorCreate = function (careernwConstants) {

        return {
            restrict: 'E',
            templateUrl: careernwConstants.clientPath + '/App_Angular/Views/create.html',
            controller: 'vendorCreateCtrl',
            controllerAs: 'vm'
        };
    };

    vendorCreate.$inject = injectParams;

    angular.module('careernw').directive('vendorCreate', vendorCreate);

}());