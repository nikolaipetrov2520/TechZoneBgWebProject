#pragma checksum "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e40b04c92e2eb05d0278d9830965b2072017ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Following), @"mvc.1.0.view", @"/Views/Users/Following.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e40b04c92e2eb05d0278d9830965b2072017ea", @"/Views/Users/Following.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Following : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Users.UsersDetailsViewModel>
    {
        private global::AspNetCore.Views_Users_Following.__Generated__UsersDetailsViewComponentTagHelper __UsersDetailsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Threads", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
   ViewData["Title"] = Model.FirstName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8e40b04c92e2eb05d0278d9830965b2072017ea4814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"tt-tab-wrapper\">\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:users-details", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e40b04c92e2eb05d0278d9830965b2072017ea6445", async() => {
            }
            );
            __UsersDetailsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Users_Following.__Generated__UsersDetailsViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__UsersDetailsViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __UsersDetailsViewComponentTagHelper.userId = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("user-id", __UsersDetailsViewComponentTagHelper.userId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        <div class=\"tab-pane tt-indent-none show active\" id=\"tt-tab-04\" role=\"tabpanel\">\n");
#nullable restore
#line 12 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
             if (Model.Following.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""tt-followers-list"" style=""word-break: break-word;"">
    <div class=""tt-list-header"">
        <div class=""tt-col-name"">User</div>
        <div class=""tt-col-value-large hide-mobile"">Threads</div>
        <div class=""tt-col-value-large hide-mobile"">Replies</div>
        <div class=""tt-col-value"">Points</div>
    </div>
");
#nullable restore
#line 21 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
     foreach (var following in Model.Following)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tt-item\">\n    <div class=\"tt-col-merged\">\n        <div class=\"tt-col-avatar\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e40b04c92e2eb05d0278d9830965b2072017ea9008", async() => {
                WriteLiteral("\n                <svg class=\"tt-icon\">\n                    <use");
                BeginWriteAttribute("xlink:href", " xlink:href=\"", 1115, "\"", 1153, 1);
#nullable restore
#line 31 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
WriteAttributeValue("", 1128, following.ProfilePicture, 1128, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></use>\n                </svg>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                 WriteLiteral(following.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n        </div>\n        <div class=\"tt-col-description\">\n            <h6 class=\"tt-title\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e40b04c92e2eb05d0278d9830965b2072017ea12147", async() => {
                WriteLiteral("\n                    ");
#nullable restore
#line 41 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                Write(following.FirstName + " " + following.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                     WriteLiteral(following.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </h6>\n        </div>\n    </div>\n    <div class=\"tt-col-value-large hide-mobile\">");
#nullable restore
#line 46 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                                           Write(following.ThreadsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"tt-col-value-large hide-mobile\">");
#nullable restore
#line 47 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                                           Write(following.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"tt-col-value\"><span class=\"tt-color16 tt-badge\">Points: ");
#nullable restore
#line 48 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                                                                   Write(following.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n</div>");
#nullable restore
#line 49 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
#nullable restore
#line 50 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tt-layout-404\">\n    <h6 class=\"tt-title\">");
#nullable restore
#line 54 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                     Write(Model.FirstName + " " + Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is not following anyone.</h6>\n</div>            ");
#nullable restore
#line 55 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var token = $(""#follow-form input[name=__RequestVerificationToken]"").val();

        function follow(id) {
            $.ajax({
                type: ""GET"",
                url: ""/Users/Follow/"" + id,
                headers: { 'X-CSRF-TOKEN': token },
                success: function (json) {
                    if (json === true) {
                        $('#follow-button').html('Following');
                        $('#followersCount').html(");
#nullable restore
#line 72 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                                             Write(Model.FollowersCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \' Followers\');\n                    } else {\n                        $(\'#follow-button\').html(\'Follow\');\n                        $(\'#followersCount\').html(");
#nullable restore
#line 75 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Users\Following.cshtml"
                                              Write(Model.FollowersCount - 1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \' Followers\');\n                    }\n                }\n            });\n        }\n    </script>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Users.UsersDetailsViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:users-details")]
        public class __Generated__UsersDetailsViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__UsersDetailsViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String userId { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("UsersDetails", new { userId });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
