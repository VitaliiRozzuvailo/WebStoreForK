using System.Web.Optimization;

namespace WebSite.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts.js").Include(
                        "~/js/jquery-1.11.1.min.js",
                        "~/js/owl.carousel.min.js",
                        "~/js/bootstrap.min.js",
                        "~/js/wow.min.js",
                        "~/js/typewriter.js",
                        "~/js/jquery.onepagenav.js",
                        "~/js/jquery.unobtrusive-ajax.min.js",
                        "~/js/jquery.bxslider.min.js",
                        "~/js/main.js"
                        ));

            bundles.Add(new StyleBundle("~/bundles/all.css").Include(
                "~/css/normalize.css",
                "~/css/bootstrap.css",
                "~/css/owl.css",
                "~/css/animate.css",
                "~/css/cardio.css",
                "~/css/jquery.bxslider.css"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}