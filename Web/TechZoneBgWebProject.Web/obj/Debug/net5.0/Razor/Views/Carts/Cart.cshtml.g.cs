#pragma checksum "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66dd4106ff5a492eed799de39d729ebc249e8e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Cart), @"mvc.1.0.view", @"/Views/Carts/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66dd4106ff5a492eed799de39d729ebc249e8e5e", @"/Views/Carts/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07548fd8e615d942829f9aa12725d4ef4e5cf592", @"/Views/_ViewImports.cshtml")]
    public class Views_Carts_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechZoneBgWebProject.Web.ViewModels.Carts.CartsListingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/close-icon-13574.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 27px; height: 27px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UpdateCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
  
    ViewData["Title"] = "??????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"containerCart\" style=\" margin-top: 50px; margin-bottom: 50px;\">\r\n    <nav class=\"tt-topic-listCart cart-list\" style=\"word-break: break-word;\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
         if (Model.Id > 0)
        {
            decimal totalSum = 0m;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2 style=""text-align:center; padding-bottom:40px;"">?????????????? ???? ??????????????????</h2>
            <table align=""center"">
                <thead>
                    <tr class=""thead-cart"">
                        <th class=""cart-min cart-text"">????????????</th>
                        <th class=""cart-text"">??????????????</th>
                        <th class=""cart-min cart-text"">???????????????? ????????</th>
                        <th class=""cart-text"">????????????????????</th>
                        <th class=""cart-text"">???????????? ????????</th>
                        <th class=""cart-text""></th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 26 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                     foreach (var product in Model.Products)
                    {
                        decimal total = product.Quantity * product.Price;
                        totalSum += total;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 1241, "\"", 1257, 1);
#nullable restore
#line 30 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 1246, product.Id, 1246, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("price", " price=\"", 1258, "\"", 1280, 1);
#nullable restore
#line 30 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 1266, product.Price, 1266, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tt-itemCart\">\r\n                            <td class=\"cart-min cart-text\">\r\n                                ");
#nullable restore
#line 32 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                           Write(product.Barcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"cart-text cart-product\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dd4106ff5a492eed799de39d729ebc249e8e5e10079", async() => {
                WriteLiteral(@"
                                    <div class=""tt-col-avatar""></div>
                                    <div class=""tt-col-description"">
                                        <div class=""tt-title"">
                                            <div style=""font-size: 16px""");
                BeginWriteAttribute("asp-area", " asp-area=\"", 1932, "\"", 1943, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                                 asp-controller=\"Products\"\r\n                                                 asp-action=\"Details\"");
                BeginWriteAttribute("asp-route-id", "\r\n                                                 asp-route-id=\"", 2091, "\"", 2167, 1);
#nullable restore
#line 42 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 2156, product.Id, 2156, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                ");
#nullable restore
#line 43 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                           Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
AddHtmlAttributeValue("", 1554, product.Id, 1554, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 35 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                                                                                                 WriteLiteral(product.Id);

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
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"cart-min cart-text\">\r\n                                <div style=\"font-size: 22px; padding: 5px;\" class=\"tt-col-value hide-mobile\">");
#nullable restore
#line 50 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                                                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ????.</div>\r\n                            </td>\r\n                            <td");
            BeginWriteAttribute("id", " id=\"", 2713, "\"", 2729, 1);
#nullable restore
#line 52 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 2718, product.Id, 2718, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""cart-text cart-quantity"">
                                <div class=""tt-col-category"">
                                    <div class=""tt-color01 tt-badge"" style=""height: 28px;"">
                                        <span data-stock=""1"" data-pid=""44977"" data-prid=""44769"" class=""add-to-cart-span""></span>
                                        <a style=""font-size: 18px; padding-left: 5px; padding-right: 5px; padding: 4px"" class=""add-to-cart-left"">-</a>
                                        <input style=""font-size: 18px; width:30px"" class=""add-to-cart-quantity"" type=""text"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3367, 1);
#nullable restore
#line 57 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 3350, product.Quantity, 3350, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly>
                                        <a style=""font-size: 18px; padding-left: 5px; padding-right: 5px; padding: 4px"" class=""add-to-cart-right"">+</a>
                                        <input type=""hidden"" id=""RequestVerificationToken""
                                               name=""RequestVerificationToken""");
            BeginWriteAttribute("value", " value=\"", 3703, "\"", 3737, 1);
#nullable restore
#line 60 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
WriteAttributeValue("", 3711, GetAntiXsrfRequestToken(), 3711, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"cart-text\">\r\n                                ");
#nullable restore
#line 65 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                           Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ????.\r\n                            </td>\r\n                            <td class=\"cart-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dd4106ff5a492eed799de39d729ebc249e8e5e18275", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66dd4106ff5a492eed799de39d729ebc249e8e5e18567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                                                                                   WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cartId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cartId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <h4 id=\"totalSum\" style=\"padding:30px; text-align:right\">???????????? ???????? ");
#nullable restore
#line 77 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
                                                                            Write(totalSum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ????.</h4>\r\n            <div class=\"pt-row\">\r\n                <div class=\"col-auto ml-md-auto mb-5\" style=\"text-align: end;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dd4106ff5a492eed799de39d729ebc249e8e5e23951", async() => {
                WriteLiteral("??????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 83 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <h3 class=\"tt-title\">???????? ???????????????? ?? ??????????????????. ???????????????? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dd4106ff5a492eed799de39d729ebc249e8e5e26001", async() => {
                WriteLiteral("??????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(", ???? ???? ???????????????????? ?? ??????????????????</h3>\r\n            </div>\r\n");
#nullable restore
#line 90 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </nav>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dd4106ff5a492eed799de39d729ebc249e8e5e27980", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
#line 96 "C:\Users\user\Desktop\TechZoneBgWeb\TechZoneBgWebProject\Web\TechZoneBgWebProject.Web\Views\Carts\Cart.cshtml"
           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechZoneBgWebProject.Web.ViewModels.Carts.CartsListingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
