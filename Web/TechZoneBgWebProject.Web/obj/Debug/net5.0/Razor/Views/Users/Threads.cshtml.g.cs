#pragma checksum "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b666b2eb7724ef8723e91dafd2ca61991e04a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Threads), @"mvc.1.0.view", @"/Views/Users/Threads.cshtml")]
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
#line 1 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\_ViewImports.cshtml"
using TechZoneBgWebProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\_ViewImports.cshtml"
using TechZoneBgWebProject.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b666b2eb7724ef8723e91dafd2ca61991e04a64", @"/Views/Users/Threads.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Threads : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Users.UsersDetailsViewModel>
    {
        private global::AspNetCore.Views_Users_Threads.__Generated__UsersDetailsViewComponentTagHelper __UsersDetailsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
   ViewData["Title"] = Model.FirstName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b666b2eb7724ef8723e91dafd2ca61991e04a645586", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"tt-tab-wrapper\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:users-details", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b666b2eb7724ef8723e91dafd2ca61991e04a647268", async() => {
            }
            );
            __UsersDetailsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Users_Threads.__Generated__UsersDetailsViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__UsersDetailsViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
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
            WriteLiteral("\r\n\r\n        <div class=\"tab-content\">\r\n            <div class=\"tab-pane tt-indent-none show active\" id=\"tt-tab-02\" role=\"tabpanel\">\r\n                <div class=\"tt-topic-list mb-5\" style=\"word-break: break-word;\">\r\n");
#nullable restore
#line 14 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                     if (Model.Threads.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""tt-list-header"">
                            <div class=""tt-col-topic"">Topic</div>
                            <div class=""tt-col-category"">Category</div>
                            <div class=""tt-col-value hide-mobile"">Likes</div>
                            <div class=""tt-col-value hide-mobile"">Replies</div>
                            <div class=""tt-col-value hide-mobile"">Views</div>
                            <div class=""tt-col-value"">Activity</div>
                        </div>
");
#nullable restore
#line 24 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                        foreach (var thread in Model.Threads)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"tt-item\">\r\n                                <div class=\"tt-col-avatar\">\r\n                                    <svg class=\"tt-icon\">\r\n                                        <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 1420, "\"", 1454, 1);
#nullable restore
#line 29 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
WriteAttributeValue("", 1433, Model.ProfilePicture, 1433, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></use>
                                    </svg>
                                </div>
                                <div class=""tt-col-description"">
                                     <h6 class=""tt-title"">
                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b666b2eb7724ef8723e91dafd2ca61991e04a6411143", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                 if (thread.IsPinned)
                                                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <svg class=\"tt-icon\">\r\n                                                        <use xlink:href=\"#icon-pinned\"></use>\r\n                                                    </svg>\r\n");
#nullable restore
#line 43 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         ");
#nullable restore
#line 44 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                    Write(thread.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                         ");
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
#line 37 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                              WriteLiteral(thread.Id);

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
            WriteLiteral(@"
                                     </h6>
                                     <div class=""row align-items-center no-gutters"">
                                        <div class=""col-11"">
                                            <ul class=""tt-list-badge"">
                                                <li class=""show-mobile"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b666b2eb7724ef8723e91dafd2ca61991e04a6415382", async() => {
                WriteLiteral("\r\n                                                        <span class=\"tt-color01 tt-badge\">");
#nullable restore
#line 55 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                                     Write(thread.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                         WriteLiteral(thread.CategoryId);

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
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 58 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                  foreach (var tag in thread.Tags)
                                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                      <li>\r\n                                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b666b2eb7724ef8723e91dafd2ca61991e04a6419034", async() => {
                WriteLiteral("\r\n                                                              <span class=\"tt-badge\">");
#nullable restore
#line 65 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                                Write(tag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                               WriteLiteral(tag.Id);

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
            WriteLiteral("\r\n                                                      </li>\r\n");
#nullable restore
#line 68 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </ul>\r\n                                        </div>\r\n                                        <div class=\"col-1 ml-auto show-mobile\">\r\n                                            <div class=\"tt-value\">");
#nullable restore
#line 72 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                             Write(thread.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                        </div>
                                     </div>
                                </div>
                                <div class=""tt-col-category"">
                                    <span class=""tt-color01 tt-badge"">");
#nullable restore
#line 77 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                 Write(thread.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"tt-col-value hide-mobile\">");
#nullable restore
#line 79 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                 Write(thread.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"tt-col-value tt-color-select  hide-mobile\">");
#nullable restore
#line 80 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                                  Write(thread.RepliesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"tt-col-value hide-mobile\">");
#nullable restore
#line 81 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                 Write(thread.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"tt-col-value hide-mobile\">");
#nullable restore
#line 82 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                                                 Write(thread.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div> \r\n");
#nullable restore
#line 84 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                        }

                     }
                     else
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <div class=\"tt-layout-404\">\r\n                             <h6 class=\"tt-title\">");
#nullable restore
#line 90 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                              Write(Model.FirstName + " " + @Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has no threads.</h6>\r\n                         </div>\r\n");
#nullable restore
#line 92 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
#line 111 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                             Write(Model.FollowersCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \' Followers\');\r\n                    } else {\r\n                        $(\'#follow-button\').html(\'Follow\');\r\n                        $(\'#followersCount\').html(");
#nullable restore
#line 114 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\Threads.cshtml"
                                              Write(Model.FollowersCount - 1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \' Followers\');\r\n                    }\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
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
