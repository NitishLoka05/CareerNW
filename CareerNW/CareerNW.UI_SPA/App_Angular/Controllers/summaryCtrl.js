
(function () {

    var injectParams = ['mainService'];

    var summaryCtrl = function (mainService) {

        var vm = this;

        vm.title = 'Vendors Summary:';

        var getVendorSummary = function () {

            mainService.getVendorSummary().$promise.then(function (response) {

                vm.vendors = response;

            });

        };

        getVendorSummary();

        var setVendors = function (response) {

            vm.vendors = response;
        };
        
        vm.deleteVendor = function (vendorId) {

            mainService.deleteVendor(vendorId).$promise.then(function (response) {

                getVendorSummary();

            });

        };
        
    };

    summaryCtrl.$inject = injectParams;

    angular.module('careernw').controller('summaryCtrl', summaryCtrl);

}());
