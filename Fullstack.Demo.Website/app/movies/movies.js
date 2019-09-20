'use strict';

angular.module('myApp.movies', ['ngRoute'])

  .config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/movies', {
      templateUrl: 'movies/movies.html',
      controller: 'MoviesCtrl'
    });
  }])

  .controller('MoviesCtrl', ['$scope', '$location', 'movieService', function ($scope, $location, movieService) {

    movieService.getMovies().then(function (data) {
      $scope.movies = data;
    }, function (error) { console.log(error) });

    $scope.sort = 'title';
    $scope.noMovie = 'assets/images/no-movie.png';
    $scope.sortFields =
      [
        { key: 'Order By:', value: 'title' },
        { key: 'Title', value: 'title' },
        { key: 'Year', value: 'year' },
        { key: 'Director', value: 'director' }
       ];

    $scope.onSelect = function (sortBy) {
      $scope.sort = sortBy;
    }

    $scope.onClick = function (movie) {
      $location.path("/moviedetails/" + movie.id);
    }

  }]);