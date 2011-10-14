﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Users
{


#line 1 "..\..\Views\Users\Profiles.cshtml"
    using NuGetGallery;

#line default
#line hidden

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/Profiles.cshtml")]
    public class Profiles : System.Web.Mvc.WebViewPage<UserProfileModel>
    {
        public Profiles()
        {
        }
        public override void Execute()
        {




#line 3 "..\..\Views\Users\Profiles.cshtml"

            ViewBag.Title = "Profiles";



#line default
#line hidden
            WriteLiteral("\r\n<div id=\"layout-main\" class=\"profile\">\r\n    <div id=\"layout-content\">\r\n        " +
            "<div id=\"content\">\r\n            <div class=\"zone zone-content\">\r\n               " +
            " <section>\r\n                    <header class=\"profile\">\r\n                      " +
            "  ");



#line 13 "..\..\Views\Users\Profiles.cshtml"
            Write(ViewHelpers.GravatarImage(Model.EmailAddress, Model.Username, 80));


#line default
#line hidden
            WriteLiteral("\r\n                        <h2>");



#line 14 "..\..\Views\Users\Profiles.cshtml"
            Write(Model.Username);


#line default
#line hidden
            WriteLiteral("</h2>\r\n                        <div class=\"stats\">\r\n                            <" +
            "span class=\"downloads\">\r\n                                <strong>");



#line 17 "..\..\Views\Users\Profiles.cshtml"
            Write(Model.TotalPackageDownloadCount);


#line default
#line hidden
            WriteLiteral(@"</strong>
                                <label>total package downloads</label>
                            </span>
                        </div>
                    </header>
                    <header><h2>Packages</h2></header>
                    <ul>
");



#line 24 "..\..\Views\Users\Profiles.cshtml"
            foreach (var package in Model.Packages)
            {


#line default
#line hidden
                WriteLiteral("                            <li>\r\n                                <div class=\"pac" +
                "kage\">\r\n                                    <div class=\"packageItem packages\">\r\n" +
                "                                        <a href=\"");



#line 28 "..\..\Views\Users\Profiles.cshtml"
                Write(Url.Package(package));


#line default
#line hidden
                WriteLiteral("\">\r\n                                            <img src=\"");



#line 29 "..\..\Views\Users\Profiles.cshtml"
                Write(package.IconUrl ?? Links.Content.Images.packageDefaultIcon_50x50_png);


#line default
#line hidden
                WriteLiteral("\" class=\"thumbnail\" title=\"");



#line 29 "..\..\Views\Users\Profiles.cshtml"
                Write(package.Id);


#line default
#line hidden
                WriteLiteral(" Package icon\" />\r\n                                        </a>\r\n                " +
                "                        <header>\r\n                                            <h" +
                "3 style=\"display: inline-block;\">\r\n                                             " +
                "   <a href=\"");



#line 33 "..\..\Views\Users\Profiles.cshtml"
                Write(Url.Package(package.Id));


#line default
#line hidden
                WriteLiteral("\">");



#line 33 "..\..\Views\Users\Profiles.cshtml"
                Write(package.Title);


#line default
#line hidden
                WriteLiteral("</a>\r\n                                            </h3>\r\n                        " +
                "                    <div class=\"downloads\">\r\n                                   " +
                "             ");



#line 36 "..\..\Views\Users\Profiles.cshtml"
                Write(package.DownloadCount);


#line default
#line hidden
                WriteLiteral(@" Downloads
                                            </div>
                                        </header>
                                        <div class=""detail"">
                                            <p class=""description"">
                                                ");



#line 41 "..\..\Views\Users\Profiles.cshtml"
                Write(package.Description);


#line default
#line hidden
                WriteLiteral("\r\n                                            </p>\r\n                             " +
                "           </div>\r\n                                    </div>\r\n                 " +
                "               </div>\r\n                            </li>\r\n");



#line 47 "..\..\Views\Users\Profiles.cshtml"
            }


#line default
#line hidden
            WriteLiteral("                    </ul>\r\n                </section>\r\n            </div>\r\n      " +
            "  </div>\r\n    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
