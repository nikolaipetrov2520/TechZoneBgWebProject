#pragma checksum "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1272275c99665045274201b066d57d7a2c1df0cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#nullable restore
#line 1 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
using TechZoneBgWebProject.Web.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1272275c99665045274201b066d57d7a2c1df0cf", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Products.ProductDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AddToCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
   ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""container"">
    <div class=""tt-single-topic-list"" style=""word-break: break-word;"">
        <div class=""tt-item tt-details"">
            <div class=""tt-single-topic"">
                <div class=""tt-item-header"">
                    <div class=""tt-item-info info-top"">
                    </div>
                    <h3 class=""tt-item-title"">
                        ");
#nullable restore
#line 14 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n                <div class=\"tt-item-description\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 707, "\"", 723, 1);
#nullable restore
#line 18 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 713, Model.Pic, 713, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 19 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                     if (this.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3 class=\"tt-item-title\">\r\n                            ");
#nullable restore
#line 22 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" лв.\r\n                        </h3>\r\n");
#nullable restore
#line 24 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3 class=\"tt-item-title\">\r\n                            ");
#nullable restore
#line 28 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                        Write(Model.Price * 2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" лв.\r\n                        </h3>\r\n");
#nullable restore
#line 30 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"details\">\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1234, "\"", 1248, 1);
#nullable restore
#line 33 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 1239, Model.Id, 1239, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <span style=\"padding-right: 5px; padding-left: 5px\" class=\"tt-color13 tt-badge\">Налично</span>\r\n");
#nullable restore
#line 35 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                         if (this.User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""tt-color01 tt-badge"" id=""btn"">
                                <span data-stock=""1"" data-pid=""44977"" data-prid=""44769"" style=""padding-right: 5px; padding-left: 5px"" class=""add-to-cart-span"">Добави в количка</span>
                                <a class=""add-to-cart-left"">-</a>
                                <input class=""add-to-cart-quantity"" type=""text"" name=""quantity"" value=""1"">
                                <a class=""add-to-cart-right"">+</a>
                                <input type=""hidden"" id=""RequestVerificationToken""
                                       name=""RequestVerificationToken""");
            BeginWriteAttribute("value", " value=\"", 2118, "\"", 2152, 1);
#nullable restore
#line 43 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 2126, GetAntiXsrfRequestToken(), 2126, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 45 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div style="" background-color: grey;color: black"" class=""tt-color01 tt-badge"">
                                <span data-stock=""1"" data-pid=""44977"" data-prid=""44769"" style=""padding-right: 5px;"" class=""add-to-cart-span"">Регистрирайте се, за да поръчате</span>
                            </div>
");
#nullable restore
#line 51 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                        <p>Баркод: ");
#nullable restore
#line 53 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                              Write(Model.Barcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </a>\r\n");
#nullable restore
#line 55 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                     if (this.User.IsTechzoneBgEmployee() || this.User.IsAdministrator())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1272275c99665045274201b066d57d7a2c1df0cf10653", async() => {
                WriteLiteral("\r\n                            <span style=\"padding-right: 5px; padding-left: 5px\" class=\"tt-color13 tt-badge\">Изтриване</span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"add-cart-popup\">\r\n    Успешно добавихте продукта в количката!\r\n</div>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1272275c99665045274201b066d57d7a2c1df0cf13699", async() => {
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\TechZoneBG\Web\TechZoneBgWebProject.Web\Views\Products\Details.cshtml"
           
    public string GetAntiXsrfRequestToken()
    {
        return Xsrf.GetAndStoreTokens(Context).RequestToken;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Products.ProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
