/*************************************************************************************************************************/
/* Http service module                                                                                                   */
/*************************************************************************************************************************/
'use strict';

angular.module('myApp')
    .config(function ($httpProvider) {
        delete $httpProvider.defaults.headers.common['Access-Control-Allow-Origin'];
        //console.log('$httpProvider');
        //$httpProvider.defaults.withCredentials = false;
    });

angular.module('myApp').service('httpUtils', ['$http', '$q', '$log',
    function ($http, $q, $log) {

        return {

            /**
             * make http GET connections and retrive information
             * @url - the remote server url.
             * @listParams - the data to be sent in the request.
             */
            GET: function (url, listParams, config) {

                var defferd = $q.defer();
                if (config != undefined) {
                    config.params = listParams;
                }

                $http.get(url).then(function (data, status, headers, config) {
                    defferd.resolve(data.data);
                }, function (data, status, headers, config) {
                    if (status === "401" || status === 401) {
                        defferd.reject({ msg: 'NOTOKEN' });
                    }
                    if (data && data.Message) {
                        defferd.reject({ status: status, msg: data.Message });
                    }
                    $log.error('cant connect to remote server and retrive information, url ' + url + ' status: ' + status);
                    defferd.reject(status);
                });

                return defferd.promise;
            }

        };
    }]);


