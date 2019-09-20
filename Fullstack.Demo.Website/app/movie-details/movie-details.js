'use strict';

angular.module('myApp.movie', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/moviedetails/:id', {
    templateUrl: 'movie-details/movie-details.html',
    controller: 'MovieDetailsCtrl'
  });
}])
  .controller('MovieDetailsCtrl', ['$scope', '$routeParams', 'movieService', 
    function ($scope, $routeParams, movieService) {

    movieService.getMovieById($routeParams.id).then(function (data) {
      $scope.movie = data;
    }, function (error) { console.log(error) });

}]);