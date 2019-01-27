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
                     "~/Content/sb-admin.css"
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
                     "~/Scripts/chart-area-demo.js"
                     ));


            // < link href = "vendor/bootstrap/css/bootstrap.min.css" rel = "stylesheet" >
            //  < link href = "vendor/fontawesome-free/css/all.min.css" rel = "stylesheet" type = "text/css" >
            //  < link href = "vendor/datatables/dataTables.bootstrap4.css" rel = "stylesheet" >
            //  < link href = "css/sb-admin.css" rel = "stylesheet" >

            //  <!-- Bootstrap core JavaScript-->
            //  <script src="vendor/jquery/jquery.min.js"></script>
            //<script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
            //<!-- Core plugin JavaScript-->
            // <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
            //
            //<!-- Page level plugin JavaScript-->
            //<script src="vendor/chart.js/Chart.min.js"></script>
            // <script src="vendor/datatables/jquery.dataTables.js"></script>
            // <script src="vendor/datatables/dataTables.bootstrap4.js"></script>
            // <!-- Custom scripts for all pages-->
            // <script src="js/sb-admin.min.js"></script>
            // <!-- Demo scripts for this page-->
            //<script src="js/demo/datatables-demo.js"></script>
            // <script src="js/demo/chart-area-demo.js"></script>



            //LOGIN
            bundles.Add(new StyleBundle("~/Content/login").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/Login-Form-Dark.css",
                     "~/Content/fontawesome-all.min.css"));
            bundles.Add(new ScriptBundle("~/Scripts/login").Include(
                     "~/Scripts/jquery-3.3.1.min.js",
                     "~/Scripts/bootstrap.js"));
        }
    }
}
