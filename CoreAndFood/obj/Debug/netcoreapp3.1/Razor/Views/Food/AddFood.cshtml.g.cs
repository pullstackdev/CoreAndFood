#pragma checksum "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21659b65d1a3d2577831868a77cf58aa50455a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_AddFood), @"mvc.1.0.view", @"/Views/Food/AddFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21659b65d1a3d2577831868a77cf58aa50455a14", @"/Views/Food/AddFood.cshtml")]
    public class Views_Food_AddFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
  
    ViewData["Title"] = "AddFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Add New Food</h3>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
 using (Html.BeginForm("AddFood", "Food", FormMethod.Post))
{
    //ekleme işleminde id'yi almaya gerek yok db kendisi veriyor
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
                                                                   //x.Name gibi aynı isimli olmalı modeldeki ile

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Category));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.categories, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Price));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Stock));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 32 "C:\Users\Guest_F\Desktop\studies\youtube\murat_yucedag_100derste_aspnetcoremvc\CoreAndFood\CoreAndFood\Views\Food\AddFood.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
