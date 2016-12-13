
(function () {

    var injectParams = ['mainService'];

    var summaryCtrl = function (mainService) {

        var vm = this;

        mainService.getVendorSummary().$promise.then(function (response) {

            vm.vendors = response;

        });



    };

    summaryCtrl.$inject = injectParams;

    angular.module('careernwapp').controller('summaryCtrl', summaryCtrl);

}());
