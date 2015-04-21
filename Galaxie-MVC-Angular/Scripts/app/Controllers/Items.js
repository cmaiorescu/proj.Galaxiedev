appRoot.controller('ItemController', function ($scope, ItemService, $routeParams, $log) {

    $scope.data = ItemService.data;

    console.log(ItemService.data);

    $scope.$watch('data.sortOptions', function (newVal, oldVal) {
        $log.log("sortOptions changed: " + newVal);        
        if (newVal.directions != oldVal.directions || newVal.fields != oldVal.fields) {
            $scope.data.pagingOptions.currentPage = 1;
            ItemService.find();
        }
    }, true);

    $scope.$watch('data.filterOptions', function (newVal, oldVal) {
        $log.log("filters changed: " + newVal);
        if (newVal !== oldVal) {
            $scope.data.pagingOptions.currentPage = 1;
            ItemService.find();
        }
    }, true);

    $scope.$watch('data.pagingOptions', function (newVal, oldVal) {
        $log.log("page changed: " + newVal);
        if (newVal !== oldVal) {
            ItemService.find();
        }
    }, true);

    $scope.$watch('data.selected', function () {
        $log.log("page selected changed ");
        $scope.data.selected = angular.copy($scope.data.selected);
        $log.log("page selected changed " + $scope.data.selected.ItemUPC);
    }, true);



    $scope.gridOptions = {
        data: 'data.items.Content',
        showFilter: false,
        multiSelect: false,
        selectedItems: $scope.data.selected,
        enablePaging: true,
        showFooter: true,
        totalServerItems: 'data.items.TotalRecords',
        pagingOptions: $scope.data.pagingOptions,
        filterOptions: $scope.data.filterOptions,
        useExternalSorting: true,
        sortInfo: $scope.data.sortOptions,
        plugins: [new ngGridFlexibleHeightPlugin()],
        columnDefs: [
                    { field: 'ItemUPC', displayName: 'UPC' }, 
                    { field: 'ItemDescription', displayName: 'Description' }
        ],
        afterSelectionChange: function (selection, event) {
            console.log("selection: " + selection.entity.ItemID);
            $scope.data.selected = angular.copy(selection.entity);
        }
    };

    $scope.updateItem = function (item) {
        userResource.update(item, function (updatedItem) {
            $scope.data.selected[0].ItemUPC = updatedItem.ItemUPC;
            $scope.data.selected[0].ItemDescription = updatedUser.ItemDescription;
        });
    };

});
