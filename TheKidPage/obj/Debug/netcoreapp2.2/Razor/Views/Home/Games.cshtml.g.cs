#pragma checksum "C:\Users\spoot\Desktop\Last year of School\TheKidPage\TheKidPage\Views\Home\Games.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5db3c92c1db483089fc267d251b710f1ffe34f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Games), @"mvc.1.0.view", @"/Views/Home/Games.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Games.cshtml", typeof(AspNetCore.Views_Home_Games))]
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
#line 1 "C:\Users\spoot\Desktop\Last year of School\TheKidPage\TheKidPage\Views\_ViewImports.cshtml"
using TheKidPage;

#line default
#line hidden
#line 2 "C:\Users\spoot\Desktop\Last year of School\TheKidPage\TheKidPage\Views\_ViewImports.cshtml"
using TheKidPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5db3c92c1db483089fc267d251b710f1ffe34f7", @"/Views/Home/Games.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6910af5064754016a68fd6d4c85b473971c2ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Games : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\spoot\Desktop\Last year of School\TheKidPage\TheKidPage\Views\Home\Games.cshtml"
  
    ViewBag.Ttitle = "Games";
    Layout = "~/Views/Shared/_KidsLayout.cshtml";

#line default
#line hidden
            BeginContext(91, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(116, 448, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5db3c92c1db483089fc267d251b710f1ffe34f73693", async() => {
                BeginContext(122, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(244, 13, false);
#line 11 "C:\Users\spoot\Desktop\Last year of School\TheKidPage\TheKidPage\Views\Home\Games.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(257, 300, true);
                WriteLiteral(@"- Kid Games</title>
     <script src=""https://code.jquery.com/jquery-3.2.1.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
");
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
            BeginContext(564, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(566, 977, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5db3c92c1db483089fc267d251b710f1ffe34f75666", async() => {
                BeginContext(572, 964, true);
                WriteLiteral(@"
    <header><h1>The Game Page</h1></header>
    <div class=""container"" id=""board"">
        <div id=""status"">Next Player: X</div>
        <div class=""row"">
            <div id=""0"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""1"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""2"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
        </div>
        <div class=""row"">
            <div id=""3"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""4"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""5"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
        </div>
        <div class=""row"">
            <div id=""6"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""7"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
            <div id=""8"" name=""square"" class=""col-xs-4 square"">&nbsp;</div>
        </div>
    </div>
   
");
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
            BeginContext(1543, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
