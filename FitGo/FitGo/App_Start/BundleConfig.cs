using System.Web;
using System.Web.Optimization;

namespace FitGo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Public/globalJs").Include(
                        "~/Public/js/jquery.min.js",
                        "~/Public/js/bootstrap.min.js",
                        "~/Public/js/custom_js/app.js",
                        "~/Public/js/custom_js/metisMenu.js",
                        "~/Public/js/custom_js/backstretch.js"));

            bundles.Add(new ScriptBundle("~/Public/Part1Js").Include(
                        "~/Public/vendors/jquery-circliful/js/jquery.circliful.min.js",
                        "~/Public/vendors/progressbar/bootstrap-progressbar.min.js",
                        "~/Public/vendors/countUp/countUp.js",
                        "~/Public/vendors/moment/min/moment.min.js"));

            bundles.Add(new ScriptBundle("~/Public/datePickerJs").Include(
                        "~/Public/vendors/air-datepicker-master/dist/js/datepicker.min.js",
                        "~/Public/vendors/air-datepicker-master/dist/js/i18n/datepicker.en.js"));

            bundles.Add(new ScriptBundle("~/Public/Part2Js").Include(
                        "~/Public/vendors/sweetalert/dist/sweetalert2.js",
                        "~/Public/vendors/fullcalendar/fullcalendar.js",
                        "~/Public/vendors/d3-chart/d3.v3.min.js",
                        "~/Public/vendors/nvd3chart/nv.d3.min.js",
                        "~/Public/vendors/jquery-easy-ticker-master/jquery.easy-ticker.min.js",
                        "~/Public/vendors/inputmask/inputmask/inputmask.js",
                        "~/Public/vendors/inputmask/inputmask/jquery.inputmask.js",
                        "~/Public/vendors/inputmask/inputmask/inputmask.date.extensions.js",
                        "~/Public/js/custom_js/admin_index.js"));
 

            bundles.Add(new StyleBundle("~/Public/globalCss").Include(
                      "~/Public/css/bootstrap.min.css",
                      "~/Public/css/font-awesome.min.css",
                      "~/Public/css/custom_css/metisMenu.css"));

            bundles.Add(new StyleBundle("~/Public/datePickerCss").Include(
                      "~/Public/vendors/air-datepicker-master/dist/css/datepicker.min.css"));

            bundles.Add(new StyleBundle("~/Public/pageLevelCss").Include(
                      "~/Public/vendors/jquery-circliful/css/jquery.circliful.css",
                      "~/Public/vendors/progressbar/css/bootstrap-progressbar.min.css",
                      "~/Public/vendors/fullcalendar/css/fullcalendar.css",
                      "~/Public/vendors/select/dist/css/bootstrap-select.min.css",
                      "~/Public/css/custom_css/calendar_custom.css",
                      "~/Public/vendors/sweetalert/dist/sweetalert2.css",
                      "~/Public/vendors/nvd3chart/nv.d3.min.css",
                      "~/Public/css/custom_css/fitness.css",
                      "~/Public/css/custom_css/panel.css",
                      "~/Public/css/custom_css/admin_dashboard.css"));

        }
    }
}
