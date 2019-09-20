angular.module('myApp').service('movieService', ['properties', 'httpUtils',
    function (properties, httpUtils) {
        var baseUrl = properties[properties.environment].serviceUrl;

        // this.getData = function () {
        //     return $http.get('assets/film.json');
        // }

        this.getMovies = function getMovies() {
            return httpUtils.GET(baseUrl + properties.apiEndPoints.movies.get);
        };

        this.getMovieById = function getMovieById(id) {
            return httpUtils.GET(baseUrl + properties.apiEndPoints.movies.get + '/' + id);
        };
    }]);