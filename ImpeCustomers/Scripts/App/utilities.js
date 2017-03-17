//Utilities Package Scripts
var Utilities = function () {
    var that = {};

    //Utilities.URL namespace
    that.URL = {
        //Utilities.QueryToObject();
        /*
            params: url (optional) like 'http://localhst:8080/Search?q=text'
            return object:
            {
                q: 'text';
            }

        */
        'QueryToObject': function (url) {
            var vars = [], hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
            }
            return vars;
        }
    };


    return that;
}();