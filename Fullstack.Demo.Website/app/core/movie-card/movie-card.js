angular.module('myApp')
.component('movieCard', {
    templateUrl: 'core/movie-card/movie-card.html',
    controller: ['$scope',function MovieCardController($scope) {
      
    }],
    bindings: {
        movie: '='
    }
});
