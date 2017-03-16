
//UI Styles
(function (window, document, $) {
    "use strict";

    //Global Package Scripts
    var Global = function () {
        var that = {};

        //Global.OnPageLoad();
        that.OnPageLoad = function () {

            //register for UI changed base client actions
            NavBar.Search.init();
        };
        $(function () { Global.OnPageLoad(); });


        return that;
    }();


    //NavBar Package Scripts
    var NavBar = function () {
        var that = {};

        //NavBar.Search
        that.Search = function () {
            function registerEvents() {
                // register for focus in and out toogle class active
                $('.navbar-top .search').on('focusin', setActive);
                $('.navbar-top .search').on('focusout', setInActive);
            };

            function setActive() {
                var parentForm = $(this).parents('.navbar-form:first');
                parentForm.find('.search').toggleClass('active', true, 500, "easeOutSine");
                parentForm.find('.glyphicon').toggleClass('active');
            }

            function setInActive() {
                var parentForm = $(this).parents('.navbar-form:first');
                parentForm.find('.search').toggleClass('active', false, 500, "easeOutSine");
                parentForm.find('.glyphicon').toggleClass('active');
            }

            return {
                //NavBar.Search.init();
                'init': registerEvents, 
            }
        }();



        return that;
    }();


}(window, document, jQuery));

