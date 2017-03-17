
//UI Styles
(function (window, document, $, Utilities) {
    "use strict";
    

    //Search Package Scripts
    var Search = function () {
        var that = {};

        //Search.OnPageLoad();
        that.OnPageLoad = function () {
            
            //restore search text from url
            setSearchFromUrlQuery();

             //register for search input
            $('#search').on('keyup', function (e) {
                var search = $(this).val();
                executeQuery(search);
            });
        };

        function setSearchFromUrlQuery() {
            var serachObj = Utilities.URL.QueryToObject();
            var search = serachObj.q;
            if (search) {
                $('#search').val(search);
            }
        }

        function executeQuery(search) {
            var input = search;
            var element = google.search.cse.element.getElement('searchresults-only0');
            if (!search) {
                element.clearAllResults();
            } else {
                element.execute(search);
            }
            return false;
        }

        $(function () { Search.OnPageLoad(); });

        return that;
    }();

}(window, document, jQuery, Utilities));