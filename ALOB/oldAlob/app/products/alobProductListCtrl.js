(function () {
    "use strict";
    angular
        .module("alobProductManagement")
        .controller("alobProductListCtrl",
                    ["alobProductResource",
                    alobProductListCtrl]);

    function alobProductListCtrl(alobProductResource) {
        var vm = this;

        alobProductResource.query(function(data) {
            vm.products = data;
        });

        vm.showImage = false;

        vm.toggleImage = function() {
            vm.showImage = !vm.showImage;
        }
    }
}());
