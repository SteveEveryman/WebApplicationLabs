#pragma checksum "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e25375ff9546a3e35565a737b75c8711968c7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
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
#line 1 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e25375ff9546a3e35565a737b75c8711968c7c", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";
    List<Review> reviews = (List<Review>)ViewData["Reviews"];

#line default
#line hidden
            BeginContext(140, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(260, 41, false);
#line 16 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 37, false);
#line 19 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(382, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(426, 47, false);
#line 22 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(517, 43, false);
#line 25 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(560, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(604, 41, false);
#line 28 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(689, 37, false);
#line 31 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(770, 41, false);
#line 34 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(855, 37, false);
#line 37 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(892, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(936, 42, false);
#line 40 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1022, 38, false);
#line 43 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 47, true);
            WriteLiteral("\r\n        </dd>\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1107, "\"", 1155, 1);
#line 46 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1113, Html.DisplayFor(model => model.PosterURL), 1113, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1156, 110, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"dl-horizontal\"></dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1266, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39fc90c5f2e04daa890c4f2115068f5d", async() => {
                BeginContext(1312, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1320, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1328, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52638b63152641d98a313b320f085130", async() => {
                BeginContext(1350, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1366, 34, true);
            WriteLiteral("\r\n</div>\r\n<h4>Reviews</h4>\r\n<hr>\r\n");
            EndContext();
#line 57 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
 foreach (Review review in reviews)
{

#line default
#line hidden
            BeginContext(1440, 70, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <p>");
            EndContext();
            BeginContext(1511, 17, false);
#line 61 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
          Write(review.UserReview);

#line default
#line hidden
            EndContext();
            BeginContext(1528, 24, true);
            WriteLiteral("</p>\r\n            <em>- ");
            EndContext();
            BeginContext(1553, 15, false);
#line 62 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
             Write(review.Reviewer);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 176, true);
            WriteLiteral("</em>\r\n        </div>\r\n        <div class=\"col-sm-2\">\r\n            <span class=\"btn-group\" role=\"group\">\r\n                <a class=\"btn btn-sm btn-outline-info btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1774, 2);
            WriteAttributeValue("", 1751, "/Review/Edit/", 1751, 13, true);
#line 66 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1764, review.ID, 1764, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 81, true);
            WriteLiteral(">Edit</a>\r\n                <a class=\"btn btn-sm btn-outline-info btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1856, "\"", 1888, 2);
            WriteAttributeValue("", 1863, "/Review/Delete/", 1863, 15, true);
#line 67 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1878, review.ID, 1878, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1889, 62, true);
            WriteLiteral(">Delete</a>\r\n            </span>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 71 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
}

#line default
#line hidden
            BeginContext(1954, 55, true);
            WriteLiteral("\r\n<div class=\"spaceabove\">\r\n    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2116, 4);
            WriteAttributeValue("", 2016, "/Review/Create/", 2016, 15, true);
#line 74 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2031, Html.DisplayFor(model => model.ID), 2031, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 2066, "?movieTitle=", 2066, 12, true);
#line 74 "C:\Users\Eamon\Desktop\School\AppEngineering\MvcMovie Part 3\MvcMovie\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2078, Html.DisplayFor(model => model.Title), 2078, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2117, 27, true);
            WriteLiteral(">Write a Review</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
