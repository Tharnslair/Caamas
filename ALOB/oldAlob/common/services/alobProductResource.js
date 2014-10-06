(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("alobProductResource",
                ["$resource",
                 alobProductResource]);

    function alobProductResource($resource) {
        return $resource("/api/products/:productId")
    }

}());