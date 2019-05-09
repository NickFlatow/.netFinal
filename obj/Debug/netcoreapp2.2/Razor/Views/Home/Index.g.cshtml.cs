#pragma checksum "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30ed36ecd54f91313262f02145cb4b17a0a2144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Northwind.Views.Home.Home.Views_Home_Index))]
namespace Northwind.Views.Home.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30ed36ecd54f91313262f02145cb4b17a0a2144", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb9f21fdb14ab6dd9f6ccfb802a953d418492f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 496, true);
            WriteLiteral(@"
<div class=""jumbotron my-2 border border-secondary"">
    <h1 class=""display-4"">Northwind</h1>
    <p class=""lead"">We have the best prices and selection of high quality foods &amp; beverages on the planet! Check out our featured discounts below.</p>
    <hr class=""my-4"">
    <p>For exceptional international quisuine, look no further.</p>
    <a class=""btn btn-outline-primary btn-lg"" href=""#"" role=""button""><i class=""fas fa-shopping-cart""></i> Order Now</a>
</div>

<div class=""row"">
");
            EndContext();
#line 13 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
     foreach (Discount d in Model)
    {

#line default
#line hidden
            BeginContext(594, 64, true);
            WriteLiteral("        <div class=\"col-md m-3 p-3 discounts\">\r\n            <h3>");
            EndContext();
            BeginContext(659, 7, false);
#line 16 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
           Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(666, 55, true);
            WriteLiteral("</h3>\r\n            <div class=\"mb-4\">\r\n                ");
            EndContext();
            BeginContext(722, 13, false);
#line 18 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
           Write(d.Description);

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </div>\r\n            <i>Discount expires: ");
            EndContext();
            BeginContext(791, 32, false);
#line 20 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
                            Write(d.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(823, 60, true);
            WriteLiteral("</i><br />\r\n            <a href=\"#\" class=\"code\" data-code=\"");
            EndContext();
            BeginContext(884, 6, false);
#line 21 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
                                           Write(d.Code);

#line default
#line hidden
            EndContext();
            BeginContext(890, 16, true);
            WriteLiteral("\" data-product=\"");
            EndContext();
            BeginContext(907, 7, false);
#line 21 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
                                                                  Write(d.Title);

#line default
#line hidden
            EndContext();
            BeginContext(914, 77, true);
            WriteLiteral("\"><i class=\"far fa-hand-point-right\"></i> Discount Code</a>\r\n        </div>\r\n");
            EndContext();
#line 23 "C:\Users\bitstudent\Source\Repos\.netFinal\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(998, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1031, 45, true);
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
