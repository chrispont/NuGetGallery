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
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using NuGetGallery;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/ChangePassword.cshtml")]
    public class ChangePassword : System.Web.Mvc.WebViewPage<PasswordChangeViewModel>
    {
        public ChangePassword()
        {
        }
        public override void Execute()
        {



#line 2 "..\..\Views\Users\ChangePassword.cshtml"

            ViewBag.Title = "Change Password";
            Layout = "~/Views/Shared/TwoColumnLayout.cshtml";



#line default
#line hidden
            WriteLiteral("\r\n");


            DefineSection("LeftNav", () =>
            {

                WriteLiteral("\r\n    <img src=\"");



#line 8 "..\..\Views\Users\ChangePassword.cshtml"
                Write(Links.Content.Images.userGraphic_png);


#line default
#line hidden
                WriteLiteral("\" alt=\"The unknown user image\" />\r\n");


            });

            WriteLiteral("                \r\n\r\n");


            DefineSection("ContentHeader", () =>
            {

                WriteLiteral("\r\n    <span class=\"right\"><img src=\"");



#line 12 "..\..\Views\Users\ChangePassword.cshtml"
                Write(Links.Content.Images.required_png);


#line default
#line hidden
                WriteLiteral("\" alt=\"Required\" /></span>\r\n    <h2>Change Password</h2>    \r\n");


            });

            WriteLiteral("\r\n\r\n<form id=\"form\" method=\"post\" action=\"");



#line 16 "..\..\Views\Users\ChangePassword.cshtml"
            Write(Url.Current());


#line default
#line hidden
            WriteLiteral("\">\r\n    ");



#line 17 "..\..\Views\Users\ChangePassword.cshtml"
            Write(Html.AntiForgeryToken());


#line default
#line hidden
            WriteLiteral("\r\n    ");



#line 18 "..\..\Views\Users\ChangePassword.cshtml"
            Write(Html.ValidationSummary(true));


#line default
#line hidden
            WriteLiteral("\r\n    ");



#line 19 "..\..\Views\Users\ChangePassword.cshtml"
            Write(Html.EditorForModel());


#line default
#line hidden
            WriteLiteral("\r\n    <div>\r\n        <button type=\"submit\" title=\"Change password\">Change Passwor" +
            "d</button> <a href=\"");



#line 21 "..\..\Views\Users\ChangePassword.cshtml"
            Write(Url.Action(MVC.Users.Account()));


#line default
#line hidden
            WriteLiteral("\">Go Back</a>\r\n    </div>\r\n</form>\r\n\r\n");


            DefineSection("BottomScripts", () =>
            {

                WriteLiteral("\r\n    <script src=\"");



#line 26 "..\..\Views\Users\ChangePassword.cshtml"
                Write(Url.Content("~/Scripts/jquery.validate.min.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");



#line 27 "..\..\Views\Users\ChangePassword.cshtml"
                Write(Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");



#line 28 "..\..\Views\Users\ChangePassword.cshtml"
                Write(Url.Content("~/Scripts/gallery.form.js"));


#line default
#line hidden
                WriteLiteral("\" type=\"text/javascript\"></script>\r\n");


            });


        }
    }
}
#pragma warning restore 1591
