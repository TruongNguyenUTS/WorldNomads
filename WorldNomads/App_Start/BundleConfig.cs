using System.Web;
using System.Web.Optimization;

namespace WorldNomads
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(                        
                        "~/Scripts/External/General/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/External/General/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/External/General/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/External/General/bootstrap.js",
                      "~/Scripts/External/General/respond.js"));

            //kendo ui & angular - angular package from Kendo
            //as kendo ui - angular document, requires to include jquery, angular before kendo (http://docs.telerik.com/kendo-ui/AngularJS/introduction)
            bundles.Add(new ScriptBundle("~/bundles/kendoui").Include(
                "~/Scripts/External/Kendo/2014.3.1411/angular.min.js",
                 "~/Scripts/External/Kendo/2014.3.1411/kendo.all.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                    "~/Content/Kendo/2014.3.1411/kendo.common.min.css",
                    "~/Content/kendo/2014.3.1411/kendo.default.min.css"));
        }
    }
}
