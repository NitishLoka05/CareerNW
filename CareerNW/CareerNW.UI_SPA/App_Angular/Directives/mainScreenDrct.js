(function () {

    var injectParams = [];

    var mainScreen = function () {

        return {
            restrict: 'E',
            templateUrl: 'http://localhost:64319' + '/App_Angular/Views/mainScreen.html',
            controller: 'mainScreenCtrl',
            controllerAs: 'mainVM'
        };
    };

    mainScreen.$inject = injectParams;

    angular.module('careernw').directive('mainScreen', mainScreen);

}());