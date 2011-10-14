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

namespace NuGetGallery.Views.Packages
{
    using System.Web.Mvc.Html;


#line 1 "..\..\Views\Packages\UploadPackage.cshtml"
    using NuGetGallery;

#line default
#line hidden

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/UploadPackage.cshtml")]
    public class UploadPackage : System.Web.Mvc.WebViewPage<SubmitPackageRequest>
    {
        public UploadPackage()
        {
        }
        public override void Execute()
        {




#line 3 "..\..\Views\Packages\UploadPackage.cshtml"

            ViewBag.Tab = "Upload";
            Layout = "~/Views/Shared/TwoColumnLayout.cshtml";



#line default
#line hidden
            WriteLiteral("\r\n");


            DefineSection("LeftNav", () =>
            {

                WriteLiteral("\r\n    <img src=\"");



#line 9 "..\..\Views\Packages\UploadPackage.cshtml"
                Write(Links.Content.Images.contribGraphic_png);


#line default
#line hidden
                WriteLiteral("\" alt=\"Contribute\" />\r\n    <p>Submit your package for others to enjoy.</p>\r\n");


            });

            WriteLiteral("    \r\n\r\n");


            DefineSection("ContentHeader", () =>
            {

                WriteLiteral("            \r\n    <h2>Upload Package</h2>\r\n    <ul class=\"right\" id=\"sequence\">\r\n" +
                "        ");



#line 16 "..\..\Views\Packages\UploadPackage.cshtml"
                Write(ViewHelpers.UploadSequence(1));


#line default
#line hidden
                WriteLiteral("\r\n    </ul>\r\n");


            });

            WriteLiteral("\r\n\r\n<div id=\"form\">\r\n    <div id=\"uploadFileForm\" class=\"selected\">\r\n        <for" +
            "m id=\"uploadFileSubmissionForm\" method=\"post\" action=\"");



#line 22 "..\..\Views\Packages\UploadPackage.cshtml"
            Write(Url.Current());


#line default
#line hidden
            WriteLiteral("\" enctype=\"multipart/form-data\">\r\n            ");



#line 23 "..\..\Views\Packages\UploadPackage.cshtml"
            Write(Html.AntiForgeryToken());


#line default
#line hidden
            WriteLiteral("\r\n            ");



#line 24 "..\..\Views\Packages\UploadPackage.cshtml"
            Write(Html.ValidationSummary(true));


#line default
#line hidden
            WriteLiteral(@"
            <aside>
                <p>Your package file will be uploaded and hosted on the gallery server.</p>
            </aside>
            <input type=""file"" id=""PackageFile"" name=""PackageFile"" />
            <div class=""buttons"">
                <input id=""uploadFileButton"" type=""submit"" value=""Upload &raquo;"" singleClickButton=""true"" />
            </div>
        </form>
    </div>
</div>
");


        }
    }
}
#pragma warning restore 1591
