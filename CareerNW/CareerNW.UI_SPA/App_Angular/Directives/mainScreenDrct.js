(function () {

    var injectParams = ['careernwConstants'];

    var mainScreen = function (careernwConstants) {

        return {
            restrict: 'E',
            templateUrl: careernwConstants.clientPath + '/App_Angular/Views/mainScreen.html',
            controller: 'mainScreenCtrl',
            controllerAs: 'mainVM'
        };
    };

    mainScreen.$inject = injectParams;

    angular.module('careernw').directive('mainScreen', mainScreen);

}());