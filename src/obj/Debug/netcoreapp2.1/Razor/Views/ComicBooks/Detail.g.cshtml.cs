#pragma checksum "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "976e9f988edc9e2dc8d948f6808e5be6ea1c0913"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComicBooks_Detail), @"mvc.1.0.view", @"/Views/ComicBooks/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComicBooks/Detail.cshtml", typeof(AspNetCore.Views_ComicBooks_Detail))]
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
#line 1 "C:\Users\FDSA\source\comic-book-gallery\src\Views\_ViewImports.cshtml"
using ComicBookGallery;

#line default
#line hidden
#line 2 "C:\Users\FDSA\source\comic-book-gallery\src\Views\_ViewImports.cshtml"
using ComicBookGallery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976e9f988edc9e2dc8d948f6808e5be6ea1c0913", @"/Views/ComicBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ba06cef919a5c080e998e4bde2babcc31fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
  
    Layout = "../Shared/_Layout.cshtml";
    ViewBag.Title = Model.DisplayText;  

#line default
#line hidden
            BeginContext(91, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(98, 17, false);
#line 6 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
Write(Model.DisplayText);

#line default
#line hidden
            EndContext();
            BeginContext(115, 129, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"well\">\r\n            <h5><label>Series Title:</label> ");
            EndContext();
            BeginContext(245, 17, false);
#line 11 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                                        Write(Model.SeriesTitle);

#line default
#line hidden
            EndContext();
            BeginContext(262, 47, true);
            WriteLiteral("</h5>\r\n            <h5><label>Issue #:</label> ");
            EndContext();
            BeginContext(310, 17, false);
#line 12 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                                   Write(Model.IssueNumber);

#line default
#line hidden
            EndContext();
            BeginContext(327, 47, true);
            WriteLiteral("</h5>\r\n            <h5><label>Favorite:</label>");
            EndContext();
            BeginContext(376, 29, false);
#line 13 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                                    Write(Model.Favorite ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(406, 79, true);
            WriteLiteral("</h5>\r\n            <h5>Artists:</h5>\r\n            <div>\r\n                <ul>\r\n");
            EndContext();
#line 17 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                     foreach (var artist in Model.Artists)
                    {

#line default
#line hidden
            BeginContext(568, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(627, 11, false);
#line 20 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                       Write(artist.Role);

#line default
#line hidden
            EndContext();
            BeginContext(638, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(641, 11, false);
#line 20 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                                     Write(artist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(652, 34, true);
            WriteLiteral(" \r\n                        </li>\r\n");
            EndContext();
#line 22 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(709, 97, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <h5>Description</h5>\r\n        ");
            EndContext();
            BeginContext(807, 31, false);
#line 27 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
   Write(Html.Raw(Model.DescriptionHtml));

#line default
#line hidden
            EndContext();
            BeginContext(838, 54, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 892, "\"", 931, 2);
            WriteAttributeValue("", 898, "/Images/", 898, 8, true);
#line 30 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
WriteAttributeValue("", 906, Model.CoverImageFileName, 906, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " \r\n            alt=\"", 932, "\"", 970, 1);
#line 31 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
WriteAttributeValue("", 952, Model.DisplayText, 952, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(971, 48, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n    </div>\r\n</div>\r\n");
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
