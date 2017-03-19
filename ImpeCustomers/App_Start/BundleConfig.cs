using System.Web;
using System.Web.Optimization;

namespace ImpeCustomers
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryuiscripts").Include(
                      "~/Content/jquery-ui-1.12.1/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryuistyle").Include(
                      "~/Content/jquery-ui-1.12.1/jquery-ui.structure.min.css",
                      "~/Content/jquery-ui-1.12.1/jquery-ui.theme.min.css",
                      "~/Content/jquery-ui-1.12.1/jquery-ui.min.css"));


            bundles.Add(new ScriptBundle("~/bundles/app/navbar").Include(
                      "~/Scripts/App/navbar.js"));
            bundles.Add(new ScriptBundle("~/bundles/app/utilities").Include(
                      "~/Scripts/App/utilities.js"));
            bundles.Add(new ScriptBundle("~/bundles/app/googlesearch").Include(
                      "~/Scripts/App/google-search.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/register").Include(
                      "~/Scripts/App/register.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/login").Include(
                      "~/Scripts/App/login.js"));

            bundles.Add(new ScriptBundle("~/bundles/app/customersservice").Include(
                      "~/Scripts/App/customers-service.js"));

        }
    }
}
