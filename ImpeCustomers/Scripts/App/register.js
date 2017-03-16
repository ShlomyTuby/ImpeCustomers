
// Register Client Functions
(function (window, document, $) {
    "use strict";

    // orgnaize all the function call when JQuery load 
    function OnPageLoad() {

        // init AoutoCompleted for Country Field
        Country.AutoCompleted.init();
        // init AoutoCompleted for City Field
        City.AutoCompleted.init();
    }
    $(function () { OnPageLoad(); });


    
    //Country Package Scripts
    var Country = function () {
        var that = {};

        //Country.AutoCompleted
        that.AutoCompleted = function () {

            var country;
            function registerEvents() {
                country = $('[name="Country"]');
                if (!country) { return false; }
                country.autocomplete({
                    source: function(request, response) {
                        $.ajax({
                            url: "/API/GetCountries",
                            type: "POST",
                            dataType: "json",
                            data: { term: request.term || '' },
                            success: function (data) {
                                response($.map(data, function (item) {
                                    return { label: item.name, value: item.value };
                                }))

                            },
                            error: console.error
                        })
                    }
                });

            }


            return {
                //Country.AutoCompleted.init();
                init: registerEvents,
            }
        }();



        return that;
    }();


    //City Package Scripts
    var City = function () {
        var that = {};

        //City.AutoCompleted
        that.AutoCompleted = function () {

            var city;
            var country;
            function registerEvents() {
                country = $('[name="Country"]');
                city = $('[name="City"]');
                if (!city) { return false; }
                city.autocomplete({
                    source: function (request, response) {
                        $.ajax({
                            url: "/API/GetCities",
                            type: "POST",
                            dataType: "json",
                            data: { term: request.term || '', country: country.val() || '' },
                            success: function (data) {
                                response($.map(data, function (item) {
                                    return { label: item.name, value: item.value };
                                }))

                            },
                            error: console.error
                        })
                    }
                });

            }


            return {
                //City.AutoCompleted.init();
                init: registerEvents,
            }
        }();



        return that;
    }();

}(window, document, jQuery));

