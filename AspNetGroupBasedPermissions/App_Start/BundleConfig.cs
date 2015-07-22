﻿using System.Web;
using System.Web.Optimization;

namespace AspNetGroupBasedPermissions
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                                      "~/Scripts/jquery-{version}.js",
                //"~/Scripts/jquery-migrate-{version}.js",
                                      "~/Scripts/jquery-ui-{version}.js",
                                      "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #region elFinder bundles

            bundles.Add(new ScriptBundle("~/Scripts/elfinder").Include(
                             "~/Content/elfinder/js/elfinder.full.js"
                //"~/Content/elfinder/js/i18n/elfinder.pt_BR.js"
                             ));

            bundles.Add(new StyleBundle("~/Content/elfinder").Include(
                            "~/Content/elfinder/css/elfinder.full.css",
                            "~/Content/elfinder/css/theme.css"));

            #endregion

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/ui-lightness/css").Include(
                                      "~/Content/themes/ui-lightness/jquery.ui.all.css"));
        }
    }
}
