#pragma checksum "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abb9f2edad3c97ab2d0e2e2029a199b03bb87a81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewBurials), @"mvc.1.0.view", @"/Views/Home/ViewBurials.cshtml")]
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
#line 1 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb9f2edad3c97ab2d0e2e2029a199b03bb87a81", @"/Views/Home/ViewBurials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7088af8761188d520fd6757092556a4fcfa0c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewBurials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewBurialsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InfoBurial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn button1 right btn-Dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", new global::Microsoft.AspNetCore.Html.HtmlString("ViewBurials"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Intex2021FagElGamous.Infrastructure.PaginationTagHelper __Intex2021FagElGamous_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
  
    ViewData["Title"] = "Burial Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<!-- Page Content -->\n<div class=\"container\">\n\n    <!-- Page Heading/Breadcrumbs -->\n    <h1 class=\"mt-4 mb-3\">\n        The Mummies\n    </h1>\n\n\n    <div class=\"row\">\n\n        <!-- Blog Entries Column -->\n        <div class=\"col-md-8\">\n\n\n");
#nullable restore
#line 22 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
             foreach (var b in Model.Burials)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Blog Post -->\n                <div class=\"card mb-4\">\n                    <h2 class=\"card-header\">");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                       Write(b.NS);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                             Write(b.NSTop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                                      Write(b.NSBottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                                                  Write(b.EW);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                                                        Write(b.EWTop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                                                                 Write(b.EWBottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" #");
#nullable restore
#line 27 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                                                                                              Write(b.BurialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <ul class=""list-unstyled mb-0"">
                                <li>West To Head: </li>
                                <li>West To Feet: </li>
                                <li>Burial Goods: </li>
                            </ul>
                        </div>
                        <div class=""col-lg-6"">
                            <ul class=""list-unstyled mb-0"">
                                <li>South To Head: </li>
                                <li>South To Feet: </li>
                                <li>Length: </li>
                            </ul>
                        </div>
                    </div>
                    <h4 class=""card-text"">Notes:</h4>
                    <p>");
#nullable restore
#line 45 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
                  Write(b.OsteologyNotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h5>Entered on January 1, 2017 By XXX  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abb9f2edad3c97ab2d0e2e2029a199b03bb87a8110871", async() => {
                WriteLiteral("Learn More &rarr;");
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
            WriteLiteral(" </h5>\n\n                </div>\n");
#nullable restore
#line 49 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <!-- Pagination -->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abb9f2edad3c97ab2d0e2e2029a199b03bb87a8112817", async() => {
                WriteLiteral("\n            ");
            }
            );
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Intex2021FagElGamous.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Intex2021FagElGamous_Infrastructure_PaginationTagHelper);
#nullable restore
#line 52 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
__Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 54 "/Users/addisonhoward/Documents/Winter 2021/IS 413/TheFinalIntex/Intex2021FagElGamous/Views/Home/ViewBurials.cshtml"
__Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <br />

        <!-- Sidebar Widgets Column -->
        <div class=""col-md-4"">

            <!-- Search Widget -->
            <div class=""card mb-4"">
                <h5 class=""card-header"">Search</h5>
                <div class=""card-body"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                        <span class=""input-group-append"">
                            <button class=""btn btn-secondary"" type=""button"">Go!</button>
                        </span>
                    </div>

                </div>
            </div>

            <!-- Side Widget -->
            <div class=""card my-4"">
                <h5 class=""card-header"">Side Widget</h5>
                <div class=""card-body"">
                    
                </div>
            </div>

        </div>

    </div>
    <!-- /.row -->

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewBurialsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
