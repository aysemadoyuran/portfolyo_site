#pragma checksum "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da120c5e2ac90120fdae5b023bf786ea93dda075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\_ViewImports.cshtml"
using portfolyo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\_ViewImports.cshtml"
using portfolyo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da120c5e2ac90120fdae5b023bf786ea93dda075", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de257515d641aa4a8bd805d2eb45921e66a0b612", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<entitylayer.Concrete.About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"col-md-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Hakkımda Güncelle</h4>\r\n            <p class=\"card-description\"> Hakkımda Bilgileri </p>\r\n");
#nullable restore
#line 89 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
             using (Html.BeginForm("Index", "About", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
           Write(Html.HiddenFor(x => x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Başlık:</label>\r\n                        ");
#nullable restore
#line 95 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 96 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Açıklama:</label>\r\n                        ");
#nullable restore
#line 103 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 104 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Mail:</label>\r\n                        ");
#nullable restore
#line 110 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 111 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Telefon No:</label>\r\n                        ");
#nullable restore
#line 117 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 118 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Adres:</label>\r\n                        ");
#nullable restore
#line 124 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 125 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-control-label\">Fotoğraf:</label>\r\n                        ");
#nullable restore
#line 131 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Imageurl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""d-flex justify-content-end"">
                        <button class=""btn btn-outline-success "">Bilgileri Güncelle</button>
                    </div>
                </div>
");
#nullable restore
#line 139 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\About\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<entitylayer.Concrete.About> Html { get; private set; }
    }
}
#pragma warning restore 1591
