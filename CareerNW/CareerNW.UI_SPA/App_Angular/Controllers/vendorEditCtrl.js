
(function () {

    var injectParams = ['mainService'];

    var vendorEditCtrl = function (mainService) {

        var vm = this;

        //mainService.getVendorSummary().$promise.then(function (response) {

        //    vm.vendors = response;

        //});

    };

    vendorEditCtrl.$inject = injectParams;

    angular.module('careernw').controller('vendorEditCtrl', vendorEditCtrl);

}());
