using System.Web;
using System.Web.Optimization;

namespace E_Commerce_Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Index/js").Include(
                      "~/Scripts/js/jquery-3.2.1.min.js",
                      "~/Scripts/js/animsition.js",
                      "~/Scripts/js/popper.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/select2.min.js",
                      "~/Scripts/js/slick.min.js",
                      "~/Scripts/slick-custom.js",
                      "~/Scripts/js/countdowntime.js",
                      "~/Scripts/js/lightbox.min.js",
                      "~/Scripts/js/sweetalert.min.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/hamburgers.min.css",
                      "~/Content/css/animsition.min.css",
                      "~/Content/css/animsition.css",
                      "~/Content/css/daterangepicker.css",
                      "~/Content/css/slick.css",
                      "~/Content/css/lightbox.min.css",
                      "~/Content/util.css",
                      "~/Content/main.css",
                      "~/Content/select2.min.css"));

            bundles.Add(new StyleBundle("~/Fonts/fonts").Include(
                "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/fonts/themify/themify-icons.css",
                "~/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                "~/fonts/elegant-font/html-css/style.css"));

            bundles.Add(new StyleBundle("~/Images/images").Include(
                "~/images/favicon.png"));
        }
    }
}
