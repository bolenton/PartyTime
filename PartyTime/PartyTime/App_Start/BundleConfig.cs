using System.Web;
using System.Web.Optimization;

namespace PartyTime
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

            bundles.Add(new ScriptBundle("~/bundles/soon").Include(
                      "~/Scripts/soon/plugins.js",
                      "~/Scripts/soon/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/soon.css",
                      "~/Content/main.css"));

            bundles.Add(new StyleBundle("~/Content/rsvpCss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/RsvpForm/font-awesome.css",
                      "~/Content/RsvpForm/form-elements.css",
                      "~/Content/RsvpForm/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/rsvpScript").Include(
                      "~/Scripts/rsvpScript/jquery.backstretch.js",
                     "~/Scripts/rsvpScript/retina-1.1.0.js",
                     "~/Scripts/rsvpScript/scripts.js"));

        }
    }
}
