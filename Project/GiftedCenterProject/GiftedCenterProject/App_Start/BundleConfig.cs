using System.Web;
using System.Web.Optimization;

namespace GiftedCenterProject
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //LAYOUT
            bundles.Add(new StyleBundle("~/Content/layout").Include(
                     "~/Content/bootstrap.min.css",
                     "~/Content/fontawesome-all.min.css",
                     "~/Content/dataTables.bootstrap4.css",
                     "~/Content/sb-admin.css",
                     "~/Content/PagedList.css"
                     ));
            bundles.Add(new ScriptBundle("~/Scripts/layout").Include(
                     
                    
                     "~/Scripts/jquery-3.3.1.min.js",
                     "~/Scripts/bootstrap.bundle.min.js",
                     "~/Scripts/jquery.easing.1.3.js",
                     "~/Scripts/Chart.min.js",
                     "~/Scripts/jquery.dataTables.js",
                     "~/Scripts/dataTables.bootstrap4.js",
                     "~/Scripts/sb-admin.min.js",
                     "~/Scripts/datatables-demo.js",
                     "~/Scripts/chart-area-demo.js",
                     "~/Scripts/Ajax.js"
                     ));
            //LOGIN
            bundles.Add(new StyleBundle("~/Content/login").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/Login-Form-Dark.css",
                     "~/Content/fontawesome-all.min.css"));
            bundles.Add(new ScriptBundle("~/Scripts/login").Include(
                     "~/Scripts/jquery-3.3.1.min.js",
                     "~/Scripts/bootstrap.js",
                      "~/Scripts/Ajax.js"));
        }
    }
}
