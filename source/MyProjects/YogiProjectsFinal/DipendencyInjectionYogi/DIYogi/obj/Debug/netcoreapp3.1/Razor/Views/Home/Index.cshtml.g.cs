#pragma checksum "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d3eb07e57d0b9e8f1d635ff827e6bff0f6f052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\_ViewImports.cshtml"
using DIYogi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\_ViewImports.cshtml"
using DIYogi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d3eb07e57d0b9e8f1d635ff827e6bff0f6f052", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b98207b27caed9366155e5241e11b91039efd9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1 p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d3eb07e57d0b9e8f1d635ff827e6bff0f6f0524814", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Dependency Injection</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3d3eb07e57d0b9e8f1d635ff827e6bff0f6f0525184", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d3eb07e57d0b9e8f1d635ff827e6bff0f6f0527066", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
     if (ViewData.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table class=\"table table-bordered table-sm table-striped\">\r\n");
#nullable restore
#line 15 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
             foreach (var kvp in ViewData)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr><td>");
#nullable restore
#line 17 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                   Write(kvp.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 17 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                                    Write(kvp.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 18 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 20 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table width=\"50%\" class=\"table table-bordered table-sm table-striped\">\r\n        <thead>\r\n            <tr><th>Name</th><th>Price</th></tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 26 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr><td colspan=\"3\" class=\"text-center\">No Model Data</td></tr>\r\n");
#nullable restore
#line 29 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                       Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                       Write(string.Format("{0:C2}", p.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 38 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjectsFinal\DipendencyInjectionYogi\DIYogi\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
