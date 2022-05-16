using System.Web;
using System.Web.Optimization;

namespace EBoutique
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Content/jsTemp").Include(
                        "~/assets/lib/jquery/jquery.min.js",
                        "~/assets/lib/bootstrap/js/bootstrap.min.js",
                        "~/assets/lib/jquery-ui-1.9.2.custom.min.js",
                        "~/ assets/lib/jquery.ui.touch-punch.min.js",
                        "~/assets/lib/jquery.dcjqaccordion.2.7.js",
                        "~/assets/lib/jquery.scrollTo.min.js",
                        "~/assets/lib/jquery.nicescroll.js",
                        "~/assets/lib/common-scripts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/cssTemp").Include(
                      "~/assets/lib/bootstrap/css/bootstrap.css",
                      "~/assets/lib/font-awesome/css/font-awesome.css",
                      "~/assets/css/style.css",
                      "~/assets/css/style-responsive.css"));
        }
    }
}
