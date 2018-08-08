#pragma checksum "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81407dfd912b7e23acfdabc9511f50c05c96e595"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81407dfd912b7e23acfdabc9511f50c05c96e595", @"/Views/ComicBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5ba06cef919a5c080e998e4bde2babcc31fae1", @"/Views/_ViewImports.cshtml")]
    public class Views_ComicBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
  
    Layout = null;

    var seriesTitle = "The Amazing Spider-Man";
    var issueNumber = 700;
    var description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
    var artists = new string[]
    {
        "Script: Dan Slott",
        "Pencils: Humberto Ramos",
        "Inks: Victor Olazaba",
        "Colors: Edgar Delgado",
        "Letters: Chris Eliopoulos"
    };

#line default
#line hidden
            BeginContext(525, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(552, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1366a40d1b0489aad9f518d08220ac4", async() => {
                BeginContext(558, 80, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\">\r\n    <title></title>\r\n");
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
            BeginContext(645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(647, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "954bd51623e843019313dee3ac29d2f0", async() => {
                BeginContext(653, 39, true);
                WriteLiteral("\r\n    <div>\r\n        <h1>\r\n            ");
                EndContext();
                BeginContext(693, 11, false);
#line 26 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
       Write(seriesTitle);

#line default
#line hidden
                EndContext();
                BeginContext(704, 50, true);
                WriteLiteral("\r\n        </h1>\r\n        <h2>\r\n            Issue #");
                EndContext();
                BeginContext(755, 11, false);
#line 29 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
              Write(issueNumber);

#line default
#line hidden
                EndContext();
                BeginContext(766, 77, true);
                WriteLiteral("\r\n        </h2>\r\n\r\n        <h5>Description:</h5>\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(844, 11, false);
#line 34 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
       Write(description);

#line default
#line hidden
                EndContext();
                BeginContext(855, 74, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <h5>Artists:</h5>\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(930, 7, false);
#line 39 "C:\Users\FDSA\source\comic-book-gallery\src\Views\ComicBooks\Detail.cshtml"
       Write(artists);

#line default
#line hidden
                EndContext();
                BeginContext(937, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(974, 9, true);
            WriteLiteral("\r\n</html>");
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
