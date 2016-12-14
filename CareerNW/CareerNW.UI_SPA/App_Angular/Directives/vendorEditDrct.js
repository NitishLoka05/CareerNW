(function () {

    var injectParams = [];

    var vendorEdit = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/edit.html',
            controller: 'vendorEditCtrl',
            controllerAs: 'editVM'
        };
    };

    vendorEdit.$inject = injectParams;

    angular.module('careernw').directive('vendorEdit', vendorEdit);

}());