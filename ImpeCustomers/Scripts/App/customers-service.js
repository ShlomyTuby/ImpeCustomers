


var CustomersService = function() {

    function GetCustomers() {
        return $.ajax({
            url: "/API/Customers",
            type: "POST",
            dataType: "json"
        });
    }


    return {
        'getCustomers': GetCustomers
    }
}