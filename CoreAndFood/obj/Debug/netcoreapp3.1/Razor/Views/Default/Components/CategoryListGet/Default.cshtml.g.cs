#pragma checksum "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryListGet\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ea03397e6fa7c839ce4c0e06186abd2a0f7a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryListGet_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryListGet/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ea03397e6fa7c839ce4c0e06186abd2a0f7a46", @"/Views/Default/Components/CategoryListGet/Default.cshtml")]
    public class Views_Default_Components_CategoryListGet_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n        <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 10 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryListGet\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 374, "\"", 422, 2);
            WriteAttributeValue("", 381, "/Default/CategoryDetails/", 381, 25, true);
#nullable restore
#line 12 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryListGet\Default.cshtml"
WriteAttributeValue("", 406, item.CategoryID, 406, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryListGet\Default.cshtml"
                                                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 13 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryListGet\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
