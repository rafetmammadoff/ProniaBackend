#pragma checksum "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7e1128bd3f146a42bcfb20b03c274407f4eb3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialViewProduct), @"mvc.1.0.view", @"/Views/Shared/_PartialViewProduct.cshtml")]
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
#line 2 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\_ViewImports.cshtml"
using Pronia.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\_ViewImports.cshtml"
using Pronia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e1128bd3f146a42bcfb20b03c274407f4eb3de", @"/Views/Shared/_PartialViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a951d30106bf34ca274d7b8b9d3dbbbaba3e44d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PartialViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("secondary-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"product-item-wrap row\">\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
     foreach (var pr in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-3 col-md-4 col-sm-6 pt-4\">\r\n            <div class=\"product-item\">\r\n                <div class=\"product-img\">\r\n                    <a href=\"shop.html\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7e1128bd3f146a42bcfb20b03c274407f4eb3de4815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 365, "~/assets/images/website-images//", 365, 32, true);
#nullable restore
#line 10 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
AddHtmlAttributeValue("", 397, pr.ProductImages.FirstOrDefault(pi=>pi.Status==true).ImgUrl, 397, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7e1128bd3f146a42bcfb20b03c274407f4eb3de6573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 592, "~/assets/images/website-images//", 592, 32, true);
#nullable restore
#line 13 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
AddHtmlAttributeValue("", 624, pr.ProductImages.FirstOrDefault(pi=>pi.Status==false).ImgUrl, 624, 61, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </a>
                    <div class=""product-add-action"">
                        <ul>
                            <li>
                                <a href=""wishlist.html""
                               data-tippy=""Add to wishlist""
                               data-tippy-inertia=""true""
                               data-tippy-animation=""shift-away""
                               data-tippy-delay=""50""
                               data-tippy-arrow=""true""
                               data-tippy-theme=""sharpborder"">
                                    <i class=""pe-7s-like""></i>
                                </a>
                            </li>
                            <li class=""quuickview-btn""
                            data-bs-toggle=""modal""
                            data-bs-target=""#quickModal"">
                                <a href=""#""
                               data-tippy=""Quickview""
                               data-tippy-inertia=""true""
");
            WriteLiteral(@"                               data-tippy-animation=""shift-away""
                               data-tippy-delay=""50""
                               data-tippy-arrow=""true""
                               data-tippy-theme=""sharpborder"">
                                    <i class=""pe-7s-look""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""cart.html""
                               data-tippy=""Add to cart""
                               data-tippy-inertia=""true""
                               data-tippy-animation=""shift-away""
                               data-tippy-delay=""50""
                               data-tippy-arrow=""true""
                               data-tippy-theme=""sharpborder"">
                                    <i class=""pe-7s-cart""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
         ");
            WriteLiteral("       </div>\r\n                <div class=\"product-content\">\r\n                    <a class=\"product-name\" href=\"shop.html\">");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
                                                        Write(pr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <div class=\"price-box pb-1\">\r\n                        <span class=\"new-price\">$");
#nullable restore
#line 59 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
                                            Write(pr.SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"rating-box\">\r\n                        <ul>\r\n");
#nullable restore
#line 63 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
                             for (var i = 0; i < pr.Rating; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><i class=\"fa fa-star\"></i></li>\r\n");
#nullable restore
#line 66 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 72 "C:\Users\LENOVO\Desktop\ProniaBackend\ProniaSolution\Pronia\Views\Shared\_PartialViewProduct.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591