#pragma checksum "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932dfbae743a678f045ff6ec7433707e144b202f"
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
#line 1 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/_ViewImports.cshtml"
using Intex2021FagElGamous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932dfbae743a678f045ff6ec7433707e144b202f", @"/Views/Home/ViewBurials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7088af8761188d520fd6757092556a4fcfa0c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewBurials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewBurialsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", new global::Microsoft.AspNetCore.Html.HtmlString("ViewBurials"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Intex2021FagElGamous.Infrastructure.PaginationTagHelper __Intex2021FagElGamous_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
  
    ViewData["Title"] = "Burial Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<!-- Page Content -->\n<div class=\"container\">\n\n    <!-- Page Heading/Breadcrumbs -->\n    <h1 class=\"mt-4 mb-3\">\n        The Mummies\n    </h1>\n\n\n    <div class=\"row\">\n\n        <!-- Blog Entries Column -->\n        <div class=\"col-md-8\">\n\n\n");
#nullable restore
#line 21 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
             foreach (var b in Model.Burials)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Blog Post -->\n                <div class=\"card mb-4\">\n                    <h2 class=\"card-header\">");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                       Write(b.NS);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                             Write(b.NSTop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                                      Write(b.NSBottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                                                  Write(b.EW);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                                                        Write(b.EWTop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                                                                 Write(b.EWBottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" #");
#nullable restore
#line 26 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                                                                              Write(b.BurialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n                    <div class=\"row\">\n                        <div class=\"col-lg-6\">\n                            <ul class=\"list-unstyled mb-0\">\n                                <li>West To Head: ");
#nullable restore
#line 30 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                             Write(b.Burialwesttohead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>West To Feet: ");
#nullable restore
#line 31 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                             Write(b.Burialwesttofeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>Burial Goods: ");
#nullable restore
#line 32 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                             Write(b.Goods);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>Length: ");
#nullable restore
#line 33 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                       Write(b.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                            </ul>\n                        </div>\n                        <div class=\"col-lg-6\">\n                            <ul class=\"list-unstyled mb-0\">\n                                <li>South To Head: ");
#nullable restore
#line 38 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                              Write(b.Burialsouthtohead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>South To Feet: ");
#nullable restore
#line 39 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                              Write(b.Burialwesttofeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>Burial Depth: ");
#nullable restore
#line 40 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                             Write(b.Burialdepth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                <li>Gender: ");
#nullable restore
#line 41 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                                       Write(b.GenderCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                            </ul>\n                        </div>\n                    </div>\n                    <h4 class=\"card-text\">Notes:</h4>\n                    <p>");
#nullable restore
#line 46 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
                  Write(b.OsteologyNotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h5>Entered on January 1, 2017 By XXX  </h5>\n                    <button class=\"btn button1 right btn-Dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1761, "\"", 1822, 3);
            WriteAttributeValue("", 1771, "location.href=\'", 1771, 15, true);
#nullable restore
#line 48 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
WriteAttributeValue("", 1786, Url.Action("ViewMummy", "Home", b), 1786, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1821, "\'", 1821, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Learn More &rarr;</button>\n                </div>\n");
#nullable restore
#line 50 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <!-- Pagination -->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932dfbae743a678f045ff6ec7433707e144b202f12210", async() => {
                WriteLiteral("\n            ");
            }
            );
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Intex2021FagElGamous.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Intex2021FagElGamous_Infrastructure_PaginationTagHelper);
#nullable restore
#line 53 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
__Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 55 "/Users/addisonhoward/Documents/Winter 2021/IS 413/NewIntex/Views/Home/ViewBurials.cshtml"
__Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Intex2021FagElGamous_Infrastructure_PaginationTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
