
(function () {

    var injectParams = ['mainService'];

    var summaryCtrl = function (mainService) {

        var vm = this;

        vm.test = 'you bro';
        //if (vm.submissionNumber) {

        //    vm.hasSubmissionNumber = true;

        //    quotebindMainService.getQuoteBindSubmissions(vm.submissionNumber).$promise.then(function (response) {

        //        vm.items = response;

        //        if (currentUser.getProfile().username === '') {
        //            currentUser.loadProfile().$promise.then(function (result) {
        //                currentUser.setProfile(result.UserID, result.UserName, result.HasReadOnlyAccess, result.HasReadWriteAccess, result.HasAdministratorAccess, result.Token);

        //                vm.readonly = (!currentUser.getProfile().hasAdminAccess &&
        //                    !currentUser.getProfile().hasWriteAccess &&
        //                    currentUser.getProfile().hasReadAccess);
        //            });
        //        }
        //        else {
        //            vm.readonly = (!currentUser.getProfile().hasAdminAccess &&
        //                !currentUser.getProfile().hasWriteAccess &&
        //                currentUser.getProfile().hasReadAccess);
        //        }

        //    });
        //}


    };

    summaryCtrl.$inject = injectParams;

    angular.module('careernwapp').controller('summaryCtrl', summaryCtrl);

}());
