using System.Web;
using System.Web.Optimization;

namespace MarioKartWeb
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // dataTables css styles
            bundles.Add(new StyleBundle("~/Content/dataTablesStyles").Include(
                      "~/Content/plugins/dataTables/datatables.min.css"));

            // dataTables js
            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                      "~/Scripts/plugins/dataTables/datatables.min.js"));

            // dataTables date time sorting js
            bundles.Add(new ScriptBundle("~/plugins/dataTablesDateTimeSort").Include(
                      "~/Scripts/plugins/dataTables/sort/datetime-moment.js"));

            // dataTables moment plugin for date time sorting js
            bundles.Add(new ScriptBundle("~/plugins/moment").Include(
                      "~/Scripts/plugins/moment/moment.min.js"));

            // datePicker css styles
            bundles.Add(new StyleBundle("~/Content/jquerycssui").Include(
                      "~/Content/themes/base/jquery-ui.css"));

            // datepicker js
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-1.12.1.js"));

        }
    }
}
