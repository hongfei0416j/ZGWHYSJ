﻿using System.Web;
using System.Web.Optimization;

namespace ChineseCulture
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 http://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/homepage").Include(
                      "~/Content/css/global.css",
                       "~/Content/css/swiper.min.css",
                        "~/Content/css/style.css",
                        "~/Content/css/cyfh.css"
                     ));
            bundles.Add(new StyleBundle("~/Content/dasai").Include(
                      "~/Content/css/global.css",
                       "~/Content/css/swiper.min.css",
                        "~/Content/css/style.css",
                        "~/Content/css/dasai.css"
                      
                     ));
            bundles.Add(new StyleBundle("~/Content/wyzz").Include(
                      "~/Content/css/global.css",
                       "~/Content/css/swiper.min.css",
                        "~/Content/css/style.css",
                        "~/Content/css/wyzz.css"

                     ));
            bundles.Add(new ScriptBundle("~/bundles/homepage").Include(
                     "~/Content/js/swiper.min.js",
                     //"~/Content/js/date.js",
                     "~/Content/js/fun.js"
                     ));
            bundles.Add(new StyleBundle("~/Content/Login").Include(
                     "~/Content/css/global.css",
                       "~/Content/css/login.css"

                    ));
            bundles.Add(new StyleBundle("~/Content/Reg").Include(
                    "~/Content/css/global.css",
                      "~/Content/css/reg.css"

                   ));
            bundles.Add(new StyleBundle("~/Content/citychangecss").Include(
                   "~/Content/citychange/changecity.css"
                  ));
            bundles.Add(new StyleBundle("~/Content/usercenter").Include(
                 "~/Content/global.css",
                   "~/Content/center.css",
                    "~/Content/global.css"
                  ));
            bundles.Add(new ScriptBundle("~/bundles/selCheckbox").Include(
                    "~/Content/selCheckbox.js",
                    "~/Content/js/center.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/citychangejs").Include(
                    "~/Content/citychange/jquery.min.js",
                     "~/Content/citychange/search.js",
                    "~/Content/citychange/changecity.js",
                     "~/Content/citychange/referrer4.js"
                     
                    ));
            bundles.Add(new ScriptBundle("~/bundles/ueditor").Include(

              "~/Content/lib/webuploader/0.1.5/webuploader.min.js",
              "~/Content/ueditor/1.4.3/ueditor.config.js",
              "~/Content/ueditor/1.4.3/ueditor.all.js",
              "~/Content/ueditor/1.4.3/lang/zh-cn/zh-cn.js"
                 ));
            /*
             * <script src="js/swiper.min.js"></script>
    <script src="js/fun.js"></script>
             <link rel="stylesheet" type="text/css" href="./css/global.css">
    <link rel="stylesheet" href="css/swiper.min.css">
    <link rel="stylesheet" type="text/css" href="./css/style.css">
             */
        }
    }
}
