#pragma checksum "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc345118504c623d30ca11b81b2ebc778b80d918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_InSale), @"mvc.1.0.view", @"/Views/Devices/InSale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc345118504c623d30ca11b81b2ebc778b80d918", @"/Views/Devices/InSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Devices_InSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TechZoneBgWebProject.Web.ViewModels.Devices.DevicesListingViewModel>>
    {
        private global::AspNetCore.Views_Devices_InSale.__Generated__DevicesDetailsViewComponentTagHelper __DevicesDetailsViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("user-id", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Devices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
  
    ViewData["Title"] = "Устройства";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"tt-tab-wrapper\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:devices-details", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc345118504c623d30ca11b81b2ebc778b80d9184949", async() => {
            }
            );
            __DevicesDetailsViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Devices_InSale.__Generated__DevicesDetailsViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__DevicesDetailsViewComponentTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <nav class=\"tt-topic-list cart-list\" style=\"word-break: break-word; margin: 40px 0px;\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
         if (Model.Any())
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2 style=""text-align:center; padding-bottom:40px;"">Устройства в продажба</h2>
            <table align=""center"">
                <thead>
                    <tr class=""thead-cart"">
                        <th class=""cart-min cart-text order-address"">Дата</th>
                        <th class=""cart-text order-address"">Устройство</th>
                        <th class=""cart-min cart-text order-name"">Продавач</th>
                        <th class=""cart-text order-comment""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                     foreach (var device in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 1045, "\"", 1060, 1);
#nullable restore
#line 30 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
WriteAttributeValue("", 1050, device.Id, 1050, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tt-itemOrder order-name\">\r\n                            <td class=\"cart-min order-address\" style=\"font-size:20px;\">\r\n                                <div>\r\n                                    ");
#nullable restore
#line 33 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                               Write(device.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"order-address\" style=\"font-size:20px;\">\r\n                                <div>\r\n                                    ");
#nullable restore
#line 38 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                               Write(device.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                                             Write(device.DeviceModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                                                                 Write(device.Memory);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                                                                                Write(device.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"cart-min cart-text cart-quantity order-comment\">\r\n                                <div>\r\n                                    ");
#nullable restore
#line 43 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                               Write(device.Seller);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"order-details\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc345118504c623d30ca11b81b2ebc778b80d91810322", async() => {
                WriteLiteral("\r\n                                    Детайли\r\n                                ");
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
#line 47 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                                                                                               WriteLiteral(device.Id);

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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 55 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"tt-layout-404\">\r\n                <h6 class=\"tt-title\">Няма устройства в продажба</h6>\r\n            </div>\r\n");
#nullable restore
#line 61 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Devices\InSale.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </nav>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TechZoneBgWebProject.Web.ViewModels.Devices.DevicesListingViewModel>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:devices-details")]
        public class __Generated__DevicesDetailsViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__DevicesDetailsViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("DevicesDetails", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
