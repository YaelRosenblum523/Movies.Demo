angular.module('myApp').directive('checkImage', ['$http', function ($http) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            attrs.$observe('ngSrc', function (ngSrc) {
                if (ngSrc) {
                    $http.get(ngSrc).then(function () {
                    }, function () {
                        element.attr('src', '/assets/images/no-movie.png'); // set default image
                    });
                }
            });
        }
    };
}]);