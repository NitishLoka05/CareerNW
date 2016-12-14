
(function () {

    var injectParams = ['mainService', '$location'];

    var vendorCreateCtrl = function (mainService, $location) {

        var vm = this;

        vm.title = 'Create Vendor:';

        vm.vendor = {};

        vm.reset = function () {
            vm.vendor = {};
        };

        vm.create = function () {
            mainService.createVendor(vm.vendor).$promise.then(function (response) {

                var test = response;
                $location.path('/summary');

            });
        };
        
    };

    vendorCreateCtrl.$inject = injectParams;

    angular.module('careernw').controller('vendorCreateCtrl', vendorCreateCtrl);

}());
