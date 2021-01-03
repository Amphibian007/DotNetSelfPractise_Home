#pragma checksum "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac934670951cede339dc6abf471afcef747747fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
#line 1 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\_ViewImports.cshtml"
using Webgentle.BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac934670951cede339dc6abf471afcef747747fe", @"/Views/Book/GetAllBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7cd8749814c13160c7cd6161dad0a34e3a5d142", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
  
    ViewData["Title"] = "All Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h3 class=\"display-4\">All books</h3>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 8 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                    <div class=""card-body"">
                        <h3 class=""card-title"">");
#nullable restore
#line 14 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
                                          Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 15 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
                                        Write(book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"d-flex justify-content-between align-items-center\">\r\n                            <div class=\"btn-group\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1036, "\"", 1065, 2);
            WriteAttributeValue("", 1043, "/book/getbook/", 1043, 14, true);
#nullable restore
#line 18 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
WriteAttributeValue("", 1057, book.Id, 1057, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">View details</a>\r\n                            </div>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 20 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
                                                 Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 25 "F:\DotNetSelfPractise_Home\source\MyProjects\WebGentle\Webgentle.BookStore\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591