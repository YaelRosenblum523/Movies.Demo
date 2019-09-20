angular.module('myApp')
.component('movieList', {
    templateUrl: 'core/movie-list/movie-list.html',
    controller: ['$scope', '$location', 
        function MovieListController($scope, $location) {
        $scope.onClick = function (movie) {
            $location.path("/moviedetails/" + movie.id);
          }
    }],
    bindings: {
        movies: '=',
        filter: '=',
        sort: '='
    }
});
