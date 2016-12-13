
(function () {

    var injectParams = ['mainService'];

    var detailsCtrl = function (mainService) {

        var vm = this;

        //mainService.getVendorSummary().$promise.then(function (response) {

        //    vm.vendors = response;

        //});

    };

    detailsCtrl.$inject = injectParams;

    angular.module('careernwapp').controller('detailsCtrl', detailsCtrl);

}());
