#pragma checksum "C:\myprojects\C#\PracticalApps\NorthwindWeb\Pages\fournisseurs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8007083d206ff2cc9aaf72b6436eaaaa85abe22a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_fournisseurs), @"mvc.1.0.razor-page", @"/Pages/fournisseurs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8007083d206ff2cc9aaf72b6436eaaaa85abe22a", @"/Pages/fournisseurs.cshtml")]
    public class Pages_fournisseurs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <h1 class=\"display-2\">Fournisseurs</h1>\r\n    <table class=\"table\">\r\n        <thead class=\"thead-inverse\">\r\n            <tr><th>Nom de compagnie</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 10 "C:\myprojects\C#\PracticalApps\NorthwindWeb\Pages\fournisseurs.cshtml"
             foreach (string name in Model.Fournisseurs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td>");
#nullable restore
#line 12 "C:\myprojects\C#\PracticalApps\NorthwindWeb\Pages\fournisseurs.cshtml"
                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 13 "C:\myprojects\C#\PracticalApps\NorthwindWeb\Pages\fournisseurs.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindWeb.Pages.FournisseursModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.FournisseursModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.FournisseursModel>)PageContext?.ViewData;
        public NorthwindWeb.Pages.FournisseursModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
