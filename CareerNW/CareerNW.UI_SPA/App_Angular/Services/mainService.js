(function () {
    "use strict";

    var injectParams = ['$resource'];

    var mainService = function ($resource) {

        var qbResource = $resource("http://localhost:64319/api/Vendor/");

        var data = {
            'getVendorSummary': getVendorSummary,
            'getVendorDetails': getVendorDetails,
        };

        function getVendorSummary() {
            var vendors = qbResource.query();
            return vendors;
        }

        function getVendorDetails(vendorId) {
            var vendor = qbResource.get({ vendorId: vendorId },
                function () {

                });
            return vendor;
        }

        return data;
    }

    mainService.$inject = injectParams;

    angular.module('careernwapp.Services').factory('mainService', mainService);

}());