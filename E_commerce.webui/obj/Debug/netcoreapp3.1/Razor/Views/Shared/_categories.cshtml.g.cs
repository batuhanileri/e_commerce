#pragma checksum "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a91be7e5de1e2449d827bf4acdff06487b4ef96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a91be7e5de1e2449d827bf4acdff06487b4ef96", @"/Views/Shared/_categories.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<E_commerce.webui.Model.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Shared\_categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 6 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Shared\_categories.cshtml"
                                                          Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 7 "C:\Users\batu_\E_commerce\E_commerce.webui\Views\Shared\_categories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<E_commerce.webui.Model.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
