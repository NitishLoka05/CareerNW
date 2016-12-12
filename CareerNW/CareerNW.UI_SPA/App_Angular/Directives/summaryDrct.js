(function () {

    //var injectParams = [];

    var summaryPage = function () {

        return {
            restrict: 'E',
            template: '<div>test</div>'
            //templateUrl: 'http://localhost:64319' + '/App_Angular/Views/summary.html',
            //controller: 'summaryCtrl',
            //controllerAs: 'summaryVM'
        };
    };

    //summaryPage .$inject = injectParams;

    angular.module('careernwapp').directive('summaryPage', summaryPage);

}());