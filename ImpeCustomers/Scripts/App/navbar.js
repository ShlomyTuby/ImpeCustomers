
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

            //register event for navigation close/open menu items
            NavBar.Navigation.init();
            
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
                $('.navbar-top .search').on('change', showSearchResult);
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

            function showSearchResult() {
                var search = $('.navbar-top .search').val();
                // TODO: show result 
                window.location.href = '/Shared/SearchResult?q=' + search;
            }

            return {
                //NavBar.Search.init();
                'init': registerEvents, 
            }
        }();


        //NavBar.Navigation
        that.Navigation = function () {
            function registerEvents() {
                // register for mouse enter to navbar link => open subcategories
                $('.main-navbar .navbar-link').on('mouseenter', OnNavbarLinkMouseEnter);
                // register for mouse leave to navbar link => remove class active (usage to check if close sub category when mouseleave on subcategory area, if its still active its will stay open)
                $('.main-navbar .navbar-link').on('mouseleave', OnNavbarLinkMouseLeave);
                // register for mouse leave to navbarSubCategory => if mouse out of the subCategory area (and not in its navbar link area) => close this section
                $('.main-navbar .navbar-sub-category').on('mouseleave', OnNavbarSubCategoryMouseLeave);
            };

            function OnNavbarLinkMouseEnter(event) {
                var linkElement = $(event.target);
                var navbarSubCategories = linkElement.parent().find('.navbar-sub-category');
                if (navbarSubCategories) {
                    CloaseLastOpenSubCategories();
                    navbarSubCategories.removeClass('close');
                    navbarSubCategories.addClass('active');
                    OpenSubCategoryAniamate(navbarSubCategories);
                }
            }

            function OpenSubCategoryAniamate(element) {
                if (element) {
                    $(element).css( 'margin-left',  "-30px" )
                        .animate({ 'margin-left': "0px" }, 70, OpenSubCategoryAniamateSubCategoris);
                }
            }

            function OpenSubCategoryAniamateSubCategoris(element) {
                element = $(this);
                if (element) {
                    var pageLinks = $(element).find('.page-link');

                    //$(pageLinks).css('opacity', "0")
                    //    .animate({ "opacity" : "1" }, 100);
                }
            }

            function OnNavbarLinkMouseLeave(event) {
                var linkElement = $(event.target);
                var navbarSubCategories = linkElement.parent().find('.navbar-sub-category');
                if (navbarSubCategories) {
                    CloaseLastOpenSubCategories();
                    navbarSubCategories.removeClass('active');
                }
            }

            function OnNavbarSubCategoryMouseLeave(event) {
                var navbarSubCategories = $(event.target);
                var linkElement = navbarSubCategories.parent().find('.navbar-link');
                if (navbarSubCategories && linkElement) {
                    if (!linkElement.hasClass('active')){
                        linkElement.addClass('close');
                    }
                }
            }

            function CloaseLastOpenSubCategories() {
                var navbarSubCategories = $('.main-navbar .navbar-sub-category').not('.open');
                if (navbarSubCategories) {
                    navbarSubCategories.addClass('close');
                }
            }

            return {
                //NavBar.Navigation.init();
                'init': registerEvents,
            }
        }();



        return that;
    }();


}(window, document, jQuery));

