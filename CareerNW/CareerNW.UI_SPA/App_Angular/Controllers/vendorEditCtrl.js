
(function () {

    var injectParams = ['mainService', '$routeParams', '$location'];

    var vendorEditCtrl = function (mainService, $routeParams, $location) {

        var vm = this;

        vm.title = 'Edit Vendor';

        vm.vendor_original = {};
        vm.vendorId = $routeParams.vendorId

        mainService.getVendorDetails(vm.vendorId).$promise.then(function (response) {

            vm.vendor = angular.copy(response);

            vm.vendor_original = angular.copy(vm.vendor);

        });

        vm.reset = function () {
            vm.vendor = angular.copy(vm.vendor_original);
        };

        vm.update = function () {
            mainService.updateVendor(vm.vendorId, vm.vendor).$promise.then(function (response) {

                $location.path('/summary');

            });
        };

    };

    vendorEditCtrl.$inject = injectParams;

    angular.module('careernw').controller('vendorEditCtrl', vendorEditCtrl);

}());
