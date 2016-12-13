
(function () {

    var injectParams = ['mainService', '$scope', '$routeParams', '$location'];

    var mainScreenCtrl = function (mainService, $scope, $routeParams, $location) {

        var vm = this;
        
        $scope.loadVendorDetails = function (path, vendorId) {

            //$location.path(path + '/' + vendorId);
            $location.path('/details');

        };

    };

    mainScreenCtrl.$inject = injectParams;

    angular.module('careernw').controller('mainScreenCtrl', mainScreenCtrl);

}());
