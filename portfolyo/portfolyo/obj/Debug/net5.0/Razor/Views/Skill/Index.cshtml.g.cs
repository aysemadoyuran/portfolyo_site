#pragma checksum "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d64a914a21521e61e277c2f0b03659670319afde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
using entitylayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64a914a21521e61e277c2f0b03659670319afde", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de257515d641aa4a8bd805d2eb45921e66a0b612", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Light table -->\r\n");
            WriteLiteral(@"<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yetenek Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 69 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 73 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
                               Write(item.MyProperty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <td class=\"budget\">\r\n                                    ");
#nullable restore
#line 76 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <div class=\"d-flex align-items-center\">\r\n                                        <span class=\"completion mr-2\">");
#nullable restore
#line 80 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
                                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                    </div>\r\n                                </td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3666, "\"", 3708, 2);
            WriteAttributeValue("", 3673, "/Skill/DeleteSkill/", 3673, 19, true);
#nullable restore
#line 83 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
WriteAttributeValue("", 3692, item.MyProperty, 3692, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3856, "\"", 3896, 2);
            WriteAttributeValue("", 3863, "/Skill/EditSkill/", 3863, 17, true);
#nullable restore
#line 84 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
WriteAttributeValue("", 3880, item.MyProperty, 3880, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Düzenle</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Skill\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <a href=\"/Skill/AddSkill/\" class=\"btn btn-outline-success\">Yeni Yetenek Ekle</a>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
