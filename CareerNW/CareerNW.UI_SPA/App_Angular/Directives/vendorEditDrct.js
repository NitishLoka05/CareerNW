(function () {

    var injectParams = ['careernwConstants'];

    var vendorEdit = function (careernwConstants) {

        return {
            restrict: 'E',
            templateUrl: careernwConstants.clientPath + '/App_Angular/Views/edit.html',
            controller: 'vendorEditCtrl',
            controllerAs: 'vm'
        };
    };

    vendorEdit.$inject = injectParams;

    angular.module('careernw').directive('vendorEdit', vendorEdit);

}());