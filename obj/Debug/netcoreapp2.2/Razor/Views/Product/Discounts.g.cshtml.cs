#pragma checksum "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd25dc1f092af1572d50a85f81ee770dd7926049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Product.Views_Product_Discounts), @"mvc.1.0.view", @"/Views/Product/Discounts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Discounts.cshtml", typeof(Northwind.Views.Home.Product.Views_Product_Discounts))]
namespace Northwind.Views.Home.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd25dc1f092af1572d50a85f81ee770dd7926049", @"/Views/Product/Discounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc336443358a39bf31ac02f3d17194e98e1e1151", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Discounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 98, true);
            WriteLiteral("\r\n\r\n<h2 class=\"mt-3\"><i class=\"fas fa-tag\"></i> Product Discounts</h2>\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 7 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
     foreach (Discount d in Model)
    {

#line default
#line hidden
            BeginContext(196, 51, true);
            WriteLiteral("        <div class=\"list-group-item\">\r\n            ");
            EndContext();
            BeginContext(248, 7, false);
#line 10 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
       Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(255, 20, true);
            WriteLiteral("<br />\r\n            ");
            EndContext();
            BeginContext(276, 13, false);
#line 11 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
       Write(d.Description);

#line default
#line hidden
            EndContext();
            BeginContext(289, 41, true);
            WriteLiteral("<br />\r\n            Discount Expires: <i>");
            EndContext();
            BeginContext(331, 32, false);
#line 12 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
                            Write(d.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(363, 60, true);
            WriteLiteral("</i><br />\r\n            <a href=\"#\" class=\"code\" data-code=\"");
            EndContext();
            BeginContext(424, 6, false);
#line 13 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
                                           Write(d.Code);

#line default
#line hidden
            EndContext();
            BeginContext(430, 16, true);
            WriteLiteral("\" data-product=\"");
            EndContext();
            BeginContext(447, 7, false);
#line 13 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
                                                                  Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(454, 77, true);
            WriteLiteral("\"><i class=\"far fa-hand-point-right\"></i> Discount Code</a>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\Users\bitstudent\Downloads\Northwind-Customer-Identity\Northwind-Customer-Identity\Views\Product\Discounts.cshtml"
    }

#line default
#line hidden
            BeginContext(538, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(571, 45, true);
                WriteLiteral("\r\n    <script src=\"/js/client.js\"></script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
