
using System.Web;
using System.Web.Optimization;

namespace Galaxie_MVC_Angular
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-1.11.4.js"));


            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/ng-grid.js",
                        "~/Scripts/ng-grid-flexible-height.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sb-admin").Include(
                        "~/Content/bower_components/metisMenu/dist/metisMenu.min.js",
                        "~/Content/bower_components/raphael/raphael-min.js",
                        "~/Content/dist/js/sb-admin-2.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app/app.js",
                        "~/Scripts/app/Controllers/Items.js",
                        "~/Scripts/app/Services/Items.js"
                        ));


            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-responsive.css",
                "~/Content/ng-grid.css"
                ));

            bundles.Add(new StyleBundle("~/Content/sb-admin").Include(                
                "~/Content/bower_components/metisMenu/dist/metisMenu.min.css",
                "~/Content/dist/css/timeline.css",
                "~/Content/dist/css/sb-admin-2.css",
                "~/Content/bower_components/morrisjs/morris.cs",
                "~/Content/bower_components/font-awesome/css/font-awesome.min.css"
                ));


            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/core.css",
                        "~/Content/themes/base/resizable.css",
                        "~/Content/themes/base/selectable.css",
                        "~/Content/themes/base/accordion.css",
                        "~/Content/themes/base/autocomplete.css",
                        "~/Content/themes/base/button.css",
                        "~/Content/themes/base/dialog.css",
                        "~/Content/themes/base/slider.css",
                        "~/Content/themes/base/tabs.css",
                        "~/Content/themes/base/datepicker.css",
                        "~/Content/themes/base/progressbar.css",
                        "~/Content/themes/base/theme.css"));
        }
    }
}