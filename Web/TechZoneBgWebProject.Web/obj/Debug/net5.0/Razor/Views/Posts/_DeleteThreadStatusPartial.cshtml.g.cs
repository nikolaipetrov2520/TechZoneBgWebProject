#pragma checksum "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DeleteThreadStatusPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e2c7d9704242a776f3f8f3376ecef8e107553e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts__DeleteThreadStatusPartial), @"mvc.1.0.view", @"/Views/Posts/_DeleteThreadStatusPartial.cshtml")]
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
#line 1 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\_ViewImports.cshtml"
using TechZoneBgWebProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\_ViewImports.cshtml"
using TechZoneBgWebProject.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e2c7d9704242a776f3f8f3376ecef8e107553e", @"/Views/Posts/_DeleteThreadStatusPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts__DeleteThreadStatusPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Posts.PostsDeleteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/like.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("like"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/dislike.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("dislike"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""tt-item"">
    <div class=""tt-info-box"">
        <h6 class=""tt-title"">Thread Status</h6>
        <div class=""tt-row-icon"">
            <div class=""tt-item"">
                <div class=""tt-icon-btn tt-position-bottom"">
                    <i class=""tt-icon""><svg><use xlink:href=""#icon-reply""></use></svg></i>
                    <span class=""tt-text"">");
#nullable restore
#line 10 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DeleteThreadStatusPartial.cshtml"
                                     Write(Model.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n            <div class=\"tt-item\">\n                <div class=\"tt-icon-btn tt-position-bottom\">\n                    <i class=\"tt-icon fas fa-eye\"></i>\n                    <span class=\"tt-text\">");
#nullable restore
#line 16 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DeleteThreadStatusPartial.cshtml"
                                     Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n            <div class=\"tt-item\">\n                <div class=\"tt-icon-btn tt-position-bottom\">\n                    <i class=\"tt-icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36e2c7d9704242a776f3f8f3376ecef8e107553e6005", async() => {
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
            WriteLiteral("</i>\n                    <span id=\"post-likes\" class=\"tt-text\">");
#nullable restore
#line 22 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DeleteThreadStatusPartial.cshtml"
                                                     Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n            <div class=\"tt-item\">\n                <div class=\"tt-icon-btn tt-position-bottom\">\n                    <i class=\"tt-icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36e2c7d9704242a776f3f8f3376ecef8e107553e7652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i>\n                    <span id=\"post-dislike\" class=\"tt-text\">");
#nullable restore
#line 28 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DeleteThreadStatusPartial.cshtml"
                                                       Write(Model.Dislike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Posts.PostsDeleteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591