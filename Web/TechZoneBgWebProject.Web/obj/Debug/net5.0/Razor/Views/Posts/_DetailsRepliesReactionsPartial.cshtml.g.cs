#pragma checksum "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f400f338884a63718e2baf11bd196c271d1934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts__DetailsRepliesReactionsPartial), @"mvc.1.0.view", @"/Views/Posts/_DetailsRepliesReactionsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f400f338884a63718e2baf11bd196c271d1934", @"/Views/Posts/_DetailsRepliesReactionsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts__DetailsRepliesReactionsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Posts.PostsRepliesDetailsViewModel>
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
            WriteLiteral("\n<button type=\"button\" class=\"tt-icon-btn\" style=\"padding: 0; border:none; background:none; outline: none; color: #666f74\"");
            BeginWriteAttribute("onclick", " onclick=\"", 200, "\"", 261, 5);
            WriteAttributeValue("", 210, "likeReaction(", 210, 13, true);
#nullable restore
#line 3 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
WriteAttributeValue("", 223, Model.Id, 223, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 232, ",", 232, 1, true);
            WriteAttributeValue(" ", 233, "\'reply-reactions\',", 234, 19, true);
            WriteAttributeValue(" ", 252, "\'reply\')", 253, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <i class=\"tt-icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f400f338884a63718e2baf11bd196c271d19345503", async() => {
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
            WriteLiteral("</i>\n    <span");
            BeginWriteAttribute("id", " id=\"", 343, "\"", 369, 2);
            WriteAttributeValue("", 348, "reply-likes-", 348, 12, true);
#nullable restore
#line 5 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
WriteAttributeValue("", 360, Model.Id, 360, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tt-text\">");
#nullable restore
#line 5 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
                                                Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</button>\n<button type=\"button\" class=\"tt-icon-btn\" style=\"padding: 0; border:none; background:none; outline: none; color: #666f74\"");
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 602, 5);
            WriteAttributeValue("", 548, "dislikeReaction(", 548, 16, true);
#nullable restore
#line 7 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
WriteAttributeValue("", 564, Model.Id, 564, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 573, ",", 573, 1, true);
            WriteAttributeValue(" ", 574, "\'reply-reactions\',", 575, 19, true);
            WriteAttributeValue(" ", 593, "\'reply\')", 594, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <i class=\"tt-icon\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f400f338884a63718e2baf11bd196c271d19348202", async() => {
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
            WriteLiteral("</i>\n    <span");
            BeginWriteAttribute("id", " id=\"", 690, "\"", 718, 2);
            WriteAttributeValue("", 695, "reply-dislike-", 695, 14, true);
#nullable restore
#line 9 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
WriteAttributeValue("", 709, Model.Id, 709, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tt-text\">");
#nullable restore
#line 9 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Posts\_DetailsRepliesReactionsPartial.cshtml"
                                                  Write(Model.Dislike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</button>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Posts.PostsRepliesDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
