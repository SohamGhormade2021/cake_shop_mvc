#pragma checksum "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e5b90804a51833cc18ef1f615d02b358e15a028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e5b90804a51833cc18ef1f615d02b358e15a028", @"/Views/Pie/List.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CakeShop.ViewModels.PiesListViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e5b90804a51833cc18ef1f615d02b358e15a0282559", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 5 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
     foreach (var pie in Model.Pies)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n            <div class=\"thumbnail\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 255, "\"", 283, 1);
#nullable restore
#line 11 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
WriteAttributeValue("", 261, pie.ImageThumbnailUrl, 261, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 284, "\"", 290, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"caption\">\r\n                    <h3 class=\"pull-right\">");
#nullable restore
#line 13 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
                                      Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <h3>\r\n                        <a>");
#nullable restore
#line 15 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
                      Write(pie.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    </h3>\r\n                    <p>");
#nullable restore
#line 17 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
                  Write(pie.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Sandbox\cake_shop_mvc\CakeShop\CakeShop\Views\Pie\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CakeShop.ViewModels.PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591