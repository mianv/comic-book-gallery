#pragma checksum "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc03df24c6869d35ab45dd2f89cf3c5ecbc69a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComicBooks_index), @"mvc.1.0.view", @"/Views/ComicBooks/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComicBooks/index.cshtml", typeof(AspNetCore.Views_ComicBooks_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc03df24c6869d35ab45dd2f89cf3c5ecbc69a8", @"/Views/ComicBooks/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ba06cef919a5c080e998e4bde2babcc31fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicBookGallery.Models.ComicBook[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
  
    ViewBag.Title = "Comic Books";

#line default
#line hidden
            BeginContext(89, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(96, 13, false);
#line 7 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(109, 30, true);
            WriteLiteral("\r\n\r\n</h2>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
     foreach (var comicBook in Model)
    {

#line default
#line hidden
            BeginContext(185, 48, true);
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <h4>");
            EndContext();
            BeginContext(234, 92, false);
#line 14 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
           Write(Html.ActionLink(comicBook.DisplayText,
                "Detail", new { id = comicBook.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(326, 23, true);
            WriteLiteral("</h4>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 349, "\"", 392, 2);
            WriteAttributeValue("", 355, "/Images/", 355, 8, true);
#line 16 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
WriteAttributeValue("", 363, comicBook.CoverImageFileName, 363, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " \r\n                alt=\"", 393, "\"", 439, 1);
#line 17 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
WriteAttributeValue("", 417, comicBook.DisplayText, 417, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(440, 62, true);
            WriteLiteral(" \r\n                class=\"img-responsive\" />\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\index.cshtml"
    }

#line default
#line hidden
            BeginContext(509, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicBookGallery.Models.ComicBook[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
