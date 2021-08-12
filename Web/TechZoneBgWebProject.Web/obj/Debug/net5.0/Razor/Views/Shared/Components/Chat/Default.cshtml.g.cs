#pragma checksum "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf5c329a724d1f32b098d3e31f571b7fc8aa16fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Chat_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Chat/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf5c329a724d1f32b098d3e31f571b7fc8aa16fd", @"/Views/Shared/Components/Chat/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Chat_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechZoneBgWebProject.Web.ViewModels.Messages.ChatViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tt-color-dark tt-underline-02"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"tt-all-avatar\">\n    <div class=\"tt-list-avatar\" style=\"overflow-y: auto; height:600px; display:block; word-break: break-word;\">\n");
#nullable restore
#line 5 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
         if (this.Model.Any())
        {
            foreach (var chat in this.Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("onclick", " onclick=\"", 322, "\"", 374, 5);
            WriteAttributeValue("", 332, "location.href", 332, 13, true);
            WriteAttributeValue(" ", 345, "=", 346, 2, true);
            WriteAttributeValue(" ", 347, "\'/Chat/WithUser/", 348, 17, true);
#nullable restore
#line 9 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
WriteAttributeValue("", 364, chat.Id, 364, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 372, "\';", 372, 2, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" class=\"tt-item\">\n    <div class=\"tt-col-avatar\">\n");
#nullable restore
#line 11 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
         if (chat.ProfilePicture.StartsWith("#icon-ava"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<svg class=\"tt-icon\">\n    <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 532, "\"", 565, 1);
#nullable restore
#line 14 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
WriteAttributeValue("", 545, chat.ProfilePicture, 545, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></use>\n</svg> ");
#nullable restore
#line 15 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<img");
            BeginWriteAttribute("src", " src=\"", 594, "\"", 687, 2);
            WriteAttributeValue("", 600, "https://res.cloudinary.com/forumnet/image/upload/t_profile-picture/", 600, 67, true);
#nullable restore
#line 18 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
WriteAttributeValue("", 667, chat.ProfilePicture, 667, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n     alt=\"avatar\"\n     class=\"tt-icon\"\n     width=\"40\"\n     height=\"40\"\n     style=\"border-radius: 50%\" />");
#nullable restore
#line 23 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"tt-col-description\">\n        <h4 class=\"tt-title\"><span>");
#nullable restore
#line 26 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
                               Write(chat.FirstName + " " + chat.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  <span class=\"time\">");
#nullable restore
#line 26 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
                                                                                                 Write(chat.LastMessageActivity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\n        <div class=\"tt-message\">");
#nullable restore
#line 27 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
                           Write(chat.LastMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n</a> ");
#nullable restore
#line 29 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
     }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tt-layout-404\">\n    <p>\n        You don\'t have any messages<br />\n        But you can ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf5c329a724d1f32b098d3e31f571b7fc8aa16fd8804", async() => {
                WriteLiteral("send");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" one now.\n    </p>\n</div>");
#nullable restore
#line 38 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Shared\Components\Chat\Default.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechZoneBgWebProject.Web.ViewModels.Messages.ChatViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
