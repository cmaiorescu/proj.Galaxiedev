// Main configuration file. Sets up AngularJS module and routes and any other config objects


var appRoot = angular.module('main', ['ngRoute', 'ngResource', 'ngGrid']);     //Define the main module

appRoot
    .config(['$routeProvider', function ($routeProvider) {
        //Setup routes to load partial templates from server. TemplateUrl is the location for the server view (Razor .cshtml view)
        $routeProvider
            .when('/Home', { url: '/', templateUrl: '/Home/Main' })
            .when('/login', { url: '/login', templateUrl: '/Home/login' })
            .when('/Query', { url: '/Query', templateUrl: '/Home/Query', controller: 'QueryController' })
            .when('/Items', { templateUrl: 'Scripts/app/views/Items/itemslist.html', controller: 'ItemController' })
            .otherwise({ redirectTo: '/Home' });
    }])
    .controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
        $scope.$on('$routeChangeSuccess', function (e, current, previous) {
            $scope.activeViewPath = $location.path();
        });
    }]);



appRoot.controller('QueryController', function ($scope, $location, $resource) {

    //var demoResource = $resource('/api/Query.xml', {}, { update: { method: 'PUT' } });

    var demoResource = $resource('/api/Query/', {}, { update: { method: 'PUT' } });

 
    demoResource.query(function (data) {
        $scope.productsList = [];
        /*angular.forEach(data, function (ItemData) {
            alert(ItemData.ItemUPC);
            $scope.productsList.push(ItemData);
        });*/

        $scope.productsList = data;

        
    });



    $scope.gridOptions = {
        data: 'productsList',
        enablePaging: true,
        showFooter: true,
        showGroupPanel: true,
        columnDefs: [{ field: 'ItemUPC', displayName: 'UPC' }, { field: 'ItemDescription', displayName: 'Description' }]
    };

     


});
