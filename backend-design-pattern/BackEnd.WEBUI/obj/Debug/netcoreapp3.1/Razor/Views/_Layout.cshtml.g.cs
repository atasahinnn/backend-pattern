#pragma checksum "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7878e5998c5d655c9427025756734884ef56257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_Layout.cshtml", typeof(AspNetCore.Views__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7878e5998c5d655c9427025756734884ef56257", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd788dc673e95ab6cd55c29d94fe6d02be39b4a7", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7878e5998c5d655c9427025756734884ef562573046", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 248, true);
                WriteLiteral("</title>\r\n    <link href=\"../node_modules/bootstrap/dist/css/bootstrap.css\" rel=\"stylesheet\" />\r\n\r\n    <script src=\"../node_modules/bootstrap/dist/js/bootstrap.js\"></script>\r\n    <script src=\"../node_modules/jquery/dist/jquery.min.js\"></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(374, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(376, 572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7878e5998c5d655c9427025756734884ef562574920", async() => {
                BeginContext(382, 23, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(406, 34, false);
#line 16 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
   Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
                EndContext();
                BeginContext(440, 129, true);
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3 my-3\">\r\n                ");
                EndContext();
                BeginContext(570, 43, false);
#line 22 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
           Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
                EndContext();
                BeginContext(613, 65, true);
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-9 my-2\">\r\n");
                EndContext();
#line 26 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
                 if (TempData["Message"] != null)
                {

#line default
#line hidden
                BeginContext(748, 63, true);
                WriteLiteral("                    <div class=\"alert alert-info\" role=\"alert\">");
                EndContext();
                BeginContext(812, 19, false);
#line 28 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
                                                          Write(TempData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(831, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 29 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
                }

#line default
#line hidden
                BeginContext(858, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(875, 12, false);
#line 30 "C:\Users\aatas\Desktop\Asp.Net Core MVC\Development\BackEnd.WEBUI\Views\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(887, 54, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(948, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
