(function () {
    "use strict";

    var injectParams = ['$resource'];

    var mainService = function ($resource) {

        var qbResource = $resource('http://localhost:60192/api/Vendor/');
        var qbResourceWithParam = $resource('http://localhost:60192/api/Vendor/:vendorId', {vendorId: '@id'});

        var data = {
            'getVendorSummary': getVendorSummary,
            'getVendorDetails': getVendorDetails,
            'deleteVendor': deleteVendor
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

        function deleteVendor(vendorId) {
            var vendors = qbResourceWithParam.remove({ vendorId: vendorId },
                function () {

                });
            return vendors;
        }

        return data;
    }

    mainService.$inject = injectParams;

    angular.module('careernw-services').factory('mainService', mainService);

}());