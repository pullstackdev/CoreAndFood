#pragma checksum "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1805b6f94bda78abfa605dcffb6d57c39335492a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1805b6f94bda78abfa605dcffb6d57c39335492a", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Category List</h2>

<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Category Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Update</th>
            <th scope=""col"">Delete</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
                       Write(category.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(category.CategoryDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(category.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 865, 2);
            WriteAttributeValue("", 820, "/Category/UpdateCategory/", 820, 25, true);
#nullable restore
#line 28 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 845, category.CategoryID, 845, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 926, "\"", 978, 2);
            WriteAttributeValue("", 933, "/Category/DeleteCategory/", 933, 25, true);
#nullable restore
#line 29 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 958, category.CategoryID, 958, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<a href=\"/Category/AddCategory\" class=\"btn btn-primary\">New Category</a>\r\n\r\n\r\n");
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