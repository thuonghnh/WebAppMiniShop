#pragma checksum "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62b7788658ff86879d4d9c7bd2798657cc19b5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCategory), @"mvc.1.0.view", @"/Views/Home/ViewCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewCategory.cshtml", typeof(AspNetCore.Views_Home_ViewCategory))]
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
#line 1 "D:\Shop\WebAppShopFull\WebApp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62b7788658ff86879d4d9c7bd2798657cc19b5a", @"/Views/Home/ViewCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75616952ad48f557dea3eb4b5ab9331af75af777", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 3 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
     foreach (Product item in Model)
    {
        

#line default
#line hidden
            BeginContext(96, 105, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <div class=\"item\">\r\n                <h2>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 201, "\"", 229, 2);
            WriteAttributeValue("", 208, "/home/detail/", 208, 13, true);
#line 9 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
WriteAttributeValue("", 221, item.Id, 221, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(230, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(232, 9, false);
#line 9 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(241, 86, true);
            WriteLiteral("</a>\r\n                </h2>\r\n                <div class=\"img\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 327, "\"", 355, 2);
            WriteAttributeValue("", 334, "/home/detail/", 334, 13, true);
#line 12 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
WriteAttributeValue("", 347, item.Id, 347, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 31, true);
            WriteLiteral(">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 387, "\"", 415, 2);
            WriteAttributeValue("", 393, "/upload/", 393, 8, true);
#line 13 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
WriteAttributeValue("", 401, item.ImageUrl, 401, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(416, 84, true);
            WriteLiteral(" />\r\n                    </a>\r\n                </div>\r\n                <p>Price: <b>");
            EndContext();
            BeginContext(501, 41, false);
#line 16 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
                        Write(Html.FormatValue(item.Price, "{0:$#,##}"));

#line default
#line hidden
            EndContext();
            BeginContext(542, 57, true);
            WriteLiteral("</b></p>\r\n            </div>\r\n        </div>           \r\n");
            EndContext();
#line 19 "D:\Shop\WebAppShopFull\WebApp\Views\Home\ViewCategory.cshtml"
    }   

#line default
#line hidden
            BeginContext(609, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591