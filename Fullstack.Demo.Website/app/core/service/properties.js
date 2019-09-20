angular.module('myApp').constant('properties', {
    environment: 'dev',
    version: '1.0',
    dev: {
        serviceUrl: 'http://localhost:2710/'
    },
    release: {
        serviceUrl: 'http://localhost:2710/'
    },
    staging: {
        serviceUrl: 'http://localhost:2710/'
    },
    test: {
        serviceUrl: 'http://localhost:2710/'
    },
    apiEndPoints: {
        movies: {
            get: 'api/movie'
        }
    }
});