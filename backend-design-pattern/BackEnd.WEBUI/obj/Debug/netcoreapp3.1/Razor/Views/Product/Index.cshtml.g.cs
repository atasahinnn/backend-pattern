#pragma checksum "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb50e2eea4e51a3ab0921900c8b670896678b01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb50e2eea4e51a3ab0921900c8b670896678b01b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd788dc673e95ab6cd55c29d94fe6d02be39b4a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackEnd.WEBUI.Models.ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
   
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 236, true);
            WriteLiteral("    <div>\r\n        <table class=\"table table-responsive\">\r\n            <tr>\r\n                <td>Ürün Adı</td>\r\n                <td>Birim Fiyatı</td>\r\n                <td>Stok Adeti</td>\r\n                <td></td>\r\n            </tr>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
            BeginContext(405, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(452, 19, false);
#line 18 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                   Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(471, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(503, 17, false);
#line 19 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                   Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(520, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(552, 20, false);
#line 20 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                   Write(product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(572, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(603, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb50e2eea4e51a3ab0921900c8b670896678b01b5965", async() => {
                BeginContext(723, 11, true);
                WriteLiteral("Add To Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                                                                                                                WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 23 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(783, 394, true);
            WriteLiteral(@"
        </table>
    </div>

    <div class=""row my-3"">
        <div class=""col"">
            <nav aria-label=""Page navigation example"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item disabled"">
                        <a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Önceki</a>
                    </li>


");
            EndContext();
#line 37 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                     for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                    {


#line default
#line hidden
            BeginContext(1278, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1309, "\"", 1373, 2);
            WriteAttributeValue("", 1317, "page-item", 1317, 9, true);
#line 40 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 1326, Model.PageInfo.CurrentPage==i+1?"active":"", 1327, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1374, 55, true);
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                   href=\"", 1429, "\"", 1500, 2);
            WriteAttributeValue("", 1472, "/product/index?page=", 1472, 20, true);
#line 42 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 1492, i + 1, 1492, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1501, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1504, 5, false);
#line 42 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                                                                   Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 44 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1574, 213, true);
            WriteLiteral("\r\n\r\n\r\n                    <li class=\"page-item\">\r\n                        <a class=\"page-link\" href=\"#\">Sonraki</a>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackEnd.WEBUI.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591