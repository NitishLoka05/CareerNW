(function () {

    var phoneFormat = function () {

        return function (number) {
            if (!number) { return ''; }

            number = String(number);

            var formattedNumber = number;

            // if the first character is '1', strip it out and add it back
            //var c = (number[0] == '1') ? '1 ' : '';
            //number = number[0] == '1' ? number.slice(1) : number;

            //removes spaces, (, ), - from the string (anything but numbers)
            number = number.replace(/[^0-9]/g, '');

            // # (###) ###-#### as c (area) front-end
            var area = number.substring(0, 3);
            var front = number.substring(3, 6);
            var end = number.substring(6, 10);

            if (front) {
                //formattedNumber = (c + "(" + area + ") " + front);
                formattedNumber = ("(" + area + ") " + front);
            }
            if (end) {
                formattedNumber += ("-" + end);
            }
            return formattedNumber;
        };

    };

    angular.module('careernw').filter('phoneFormat', phoneFormat);

}());