#pragma checksum "C:\Users\Aysema Doyuran\Desktop\web\portfolyo\portfolyo\Views\Admin\PartialSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f401ef974d0149e8869186de3b5f8e862a9c08e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialSideBar), @"mvc.1.0.view", @"/Views/Admin/PartialSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f401ef974d0149e8869186de3b5f8e862a9c08e3", @"/Views/Admin/PartialSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de257515d641aa4a8bd805d2eb45921e66a0b612", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""navbar-inner"">
    <!-- Collapse -->
    <div class=""collapse navbar-collapse"" id=""sidenav-collapse-main"">
        <!-- Nav items -->
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""dashboard.html"">
                    <i class=""ni ni-tv-2 text-primary""></i>
                    <span class=""nav-link-text"">Dashboard</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Feature/Index"">
                    <i class=""ni ni-planet text-orange""></i>
                    <span class=""nav-link-text"">Öne Çıkan</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link active"" href=""/Skill/Index"">
                    <i class=""ni ni-pin-3 text-primary""></i>
                    <span class=""nav-link-text"">Yetenekler</span>
                </a>
            </li>
            <li class=""nav-item"">
       ");
            WriteLiteral(@"         <a class=""nav-link"" href=""/About/Index"">
                    <i class=""ni ni-single-02 text-yellow""></i>
                    <span class=""nav-link-text"">Hakkımda</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Portfolio/Index"">
                    <i class=""ni ni-bullet-list-67 text-default""></i>
                    <span class=""nav-link-text"">Projeler</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Exprerience/Index"">
                    <i class=""ni ni-key-25 text-info""></i>
                    <span class=""nav-link-text"">Deneyimler</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Service/Index"">
                    <i class=""ni ni-key-25 text-info""></i>
                    <span class=""nav-link-text"">Hizmetler</span>
                </a>
            </li>");
            WriteLiteral(@"
            <li class=""nav-item"">
                <a class=""nav-link"" href=""register.html"">
                    <i class=""ni ni-circle-08 text-pink""></i>
                    <span class=""nav-link-text"">İletişim</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""upgrade.html"">
                    <i class=""ni ni-send text-dark""></i>
                    <span class=""nav-link-text"">Mesajlar</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""upgrade.html"">
                    <i class=""ni ni-send text-dark""></i>
                    <span class=""nav-link-text"">Ayarlar</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""upgrade.html"">
                    <i class=""ni ni-send text-dark""></i>
                    <span class=""nav-link-text"">İstatistikler</span>
                </a>
    ");
            WriteLiteral(@"        </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""upgrade.html"">
                    <i class=""ni ni-send text-dark""></i>
                    <span class=""nav-link-text"">Oturumu Kapat</span>
                </a>
            </li>
        </ul>
       
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
