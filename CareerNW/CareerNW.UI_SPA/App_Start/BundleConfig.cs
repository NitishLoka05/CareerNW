using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CareerNW.UI_SPA.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/bundles/careernwstyle").Include(
                        "~/Content/Site.css",
                        "~/Content/bootstrap.css",
                        "~/Content/angular-block-ui.css"));

            bundles.Add(new ScriptBundle("~/bundles/careernwscript").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-route.js",
                        "~/Scripts/angular-resource.js",

                        "~/App_Angular/careernwapp.js",
                        "~/App_Angular/careernwapp.Routes.js",
                        "~/App_Angular/careernwapp.Services.js",

                        //Directives
                        "~/App_Angular/Directives/vendorSummaryDrct.js",
                        "~/App_Angular/Directives/vendorDetailsCtrl.js",

                        //Controllers
                        "~/App_Angular/Controllers/summaryCtrl.js",
                        "~/App_Angular/Controllers/detailsCtrl.js",

                        //Services
                        "~/App_Angular/Services/mainService.js"//,

                        //Filters
                        //"~/App_Angular/filters/phoneFilter.js"
                        ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}