#pragma checksum "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c91150a9be489136279cda06e65575ea88d879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_PersonInfo), @"mvc.1.0.view", @"/Views/First/PersonInfo.cshtml")]
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
#line 1 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\_ViewImports.cshtml"
using FirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\_ViewImports.cshtml"
using FirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c91150a9be489136279cda06e65575ea88d879", @"/Views/First/PersonInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b951a5d3431184d260cd5fa679540aa680aa4c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_First_PersonInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml"
  
    ViewData["Title"] = "PersonInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PersonInfo</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 9 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 10 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 11 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml"
Write(Model.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 12 "F:\DotNetSelfPractise_Home\source\MyProjects\YogiProjects\FirstApp\Views\First\PersonInfo.cshtml"
Write(Model.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
