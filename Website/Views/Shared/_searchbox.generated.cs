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

namespace NuGetGallery.Views.Shared
{
    using NuGetGallery;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_searchbox.cshtml")]
    public class _searchbox : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _searchbox()
        {
        }
        public override void Execute()
        {
            WriteLiteral("<form id=\"search-form\" action=\"");



#line 1 "..\..\Views\Shared\_searchbox.cshtml"
            Write(Url.PackageList());


#line default
#line hidden
            WriteLiteral("\" method=\"get\">\r\n    <div id=\"search\">\r\n        <div>\r\n            <input type=\"t" +
            "ext\" name=\"q\" id=\"searchTerm\" value=\"");



#line 4 "..\..\Views\Shared\_searchbox.cshtml"
            Write(ViewBag.SearchTerm ?? "Search Packages");


#line default
#line hidden
            WriteLiteral("\" />\r\n        </div>\r\n        ");



            WriteLiteral("\r\n        <input type=\"hidden\" name=\"sortOrder\" value=\"");



#line 7 "..\..\Views\Shared\_searchbox.cshtml"
            Write(Const.DefaultPackageListSortOrder);


#line default
#line hidden
            WriteLiteral("\" />\r\n        <input type=\"submit\" value=\" \"/>\r\n    </div>\r\n</form>");


        }
    }
}
#pragma warning restore 1591
