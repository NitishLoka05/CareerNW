(function () {
    "use strict";

    var injectParams = ['$resource'];

    var mainService = function ($resource) {

        var qbResource = $resource('http://localhost:60192/api/Vendor/');
        var qbResource_params = $resource('http://localhost:60192/api/Vendor/:vendorId', { vendorId: '@id' });
        var qbResource_params_update = $resource('http://localhost:60192/api/Vendor/:vendorId', { vendorId: '@id' }, { 'update': { method: 'PUT' } });

        var data = {
            'getVendorSummary': getVendorSummary,
            'getVendorDetails': getVendorDetails,
            'createVendor': createVendor,
            'updateVendor': updateVendor,
            'deleteVendor': deleteVendor
        };

        function getVendorSummary() {
            var vendors = qbResource.query();
            return vendors;
        }

        function getVendorDetails(vendorId) {
            var vendor = qbResource_params.get({ vendorId: vendorId },
                function (response) {

                });
            return vendor;
        }

        function createVendor(vendor) {
            var result = qbResource.save(vendor,
                function (response) {

                });
            return result;
        }

        function updateVendor(vendorId, vendor) {
            var result = qbResource_params_update.update({ vendorId: vendorId }, vendor,
                function (response) {

                });
            return result;
        }

        function deleteVendor(vendorId) {
            var vendors = qbResource_params.remove({ vendorId: vendorId },
                function () {

                });
            return vendors;
        }

        return data;
    }

    mainService.$inject = injectParams;

    angular.module('careernw-services').factory('mainService', mainService);

}());