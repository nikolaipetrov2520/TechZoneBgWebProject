#pragma checksum "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f296c7774cccf58d193c88f6f173d1e428c411c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__DetailsPartial), @"mvc.1.0.view", @"/Views/Users/_DetailsPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
using TechZoneBgWebProject.Web.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f296c7774cccf58d193c88f6f173d1e428c411c", @"/Views/Users/_DetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__DetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Users.UsersOrdersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Executed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"tt-wrapper-section\">\r\n    <div class=\"container\">\r\n        <div class=\"tt-user-header\">\r\n            <div class=\"tt-col-avatar\">\r\n                <div class=\"tt-icon\">\r\n                    <svg class=\"tt-icon\">\r\n                        <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 384, "\"", 418, 1);
#nullable restore
#line 10 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
WriteAttributeValue("", 397, Model.ProfilePicture, 397, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></use>\r\n                    </svg>\r\n                </div>\r\n            </div>\r\n            <div class=\"tt-col-title\">\r\n                <div class=\"tt-title\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f296c7774cccf58d193c88f6f173d1e428c411c5353", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
                    Write(Model.FirstName + " " + Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
                         WriteLiteral(Model.Id);

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
                </div>
                <ul class=""tt-list-badge"">
                    <li>
                        <a href=""#"">
                            <span class=""tt-color14 tt-badge"" style=""background-color:#60a3eb; padding-left:10px; padding-right:10px"">Поръчки които се обработват: ");
#nullable restore
#line 26 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
                                                                                                                                                              Write(Model.ExecutingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
             if (Model.Id == this.User.GetId())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Identity/Account/Manage\" class=\"tt-icon-btn\" style=\"color: #666f74\">\r\n                <i class=\"fas fa-cog\"></i>\r\n            </a> ");
#nullable restore
#line 36 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Users\_DetailsPartial.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Users.UsersOrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
