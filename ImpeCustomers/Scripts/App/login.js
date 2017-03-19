
//UI Styles
(function (window, document, $) {
    "use strict";

    //Login Package Scripts
    var Login = function () {
        var that = {};

        that.OnPageLoad = function () {
            that.ExternalLogin.init();
        };

        //Login.ExternalLogin
        that.ExternalLogin = function () {

            //Login.ExternalLogin.init()
            function init() {
            }

            return {
                //Login.ExternalLogin.init;
                'init': init,
            }
        }();


        $(function () { Login.OnPageLoad(); });



        return that;
    }();


}(window, document, jQuery));

