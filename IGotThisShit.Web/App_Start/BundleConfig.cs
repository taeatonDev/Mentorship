using System.Data.Metadata.Edm;
using System.Web;
using System.Web.Optimization;

namespace IGotThisShit.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {        

            //CSS Bundles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/themes/base/jquery.ui.css",
                "~/Content/themes/base/jquery.ui.accordion.css",
                "~/Content/themes/base/jquery.ui.all.css",
                "~/Content/themes/base/jquery.ui.autocomplete.css",
                "~/Content/themes/base/jquery.ui.base.css",
                "~/Content/themes/base/jquery.ui.button.css",
                "~/Content/themes/base/jquery.ui.core.css",
                "~/Content/themes/base/jquery.ui.datepicker.css",
                "~/Content/themes/base/jquery.ui.dialog.css",
                "~/Content/themes/base/jquery.ui.menu.css",
                "~/Content/themes/base/jquery.ui.progressbar.css",
                "~/Content/themes/base/jquery.ui.resizable.css",
                "~/Content/themes/base/jquery.ui.selectable.css",
                "~/Content/themes/base/jquery.ui.slider.css",
                "~/Content/themes/base/jquery.ui.spinner.css",
                "~/Content/themes/base/jquery.ui.tabs.css",
                "~/Content/themes/base/jquery.ui.theme.css",
                "~/Content/themes/base/jquery.ui.tooltip.css",
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/site.css"
                ));

            //JS Libraries
            bundles.Add(new ScriptBundle("~/bundles/JSLib").Include(
                "~/Scripts/jquery-{version}.min.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/modernizr-{version}.js",
                "~/Scripts/underscore.js"
                ));

            //JS Head
            bundles.Add(new ScriptBundle("~/bundles/siteHead").Include(
                "~/Scripts/siteHead.js"));

            //JS Foot
            bundles.Add(new ScriptBundle("~/bundles/siteFoot").Include(
                "~/Scripts/siteFoot.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}