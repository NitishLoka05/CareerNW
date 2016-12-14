
(function () {

    var injectParams = ['mainService', '$scope', '$routeParams', '$location'];

    var mainScreenCtrl = function (mainService, $scope, $routeParams, $location) {

        var vm = this;
        
        $scope.editVendor = function (vendorId) {

            $location.path('/edit/'+ vendorId);

        };

    };

    mainScreenCtrl.$inject = injectParams;

    angular.module('careernw').controller('mainScreenCtrl', mainScreenCtrl);

}());
