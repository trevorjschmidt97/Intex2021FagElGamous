#pragma checksum "/Users/trevorschmidt/Desktop/intex2.1/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5840119745d358927cb71cebe7641e16bdc2b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMummy), @"mvc.1.0.view", @"/Views/Home/ViewMummy.cshtml")]
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
#line 1 "/Users/trevorschmidt/Desktop/intex2.1/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trevorschmidt/Desktop/intex2.1/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trevorschmidt/Desktop/intex2.1/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trevorschmidt/Desktop/intex2.1/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5840119745d358927cb71cebe7641e16bdc2b30", @"/Views/Home/ViewMummy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7088af8761188d520fd6757092556a4fcfa0c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMummy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n<!-- Page Content -->\n<div class=\"container\">\n\n\n    <!-- Page Heading/Breadcrumbs -->\n    <h1 class=\"mt-4 mb-3\">\n        Mummy Title Here\n    </h1>\n\n\n    <ol class=\"breadcrumb\">\n        <li class=\"breadcrumb-item\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5840119745d358927cb71cebe7641e16bdc2b304914", async() => {
                WriteLiteral("Home");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
        <li class=""breadcrumb-item active"">Home Page</li>
    </ol>


    <div class=""row"">


        <!-- Post Content Column -->
        <div class=""col-lg-8"">


            <!-- Preview Image -->
            <img class=""img-fluid rounded"" src=""http://placehold.it/900x300""");
            BeginWriteAttribute("alt", " alt=\"", 709, "\"", 715, 0);
            EndWriteAttribute();
            WriteLiteral(@">


            <hr>


            <!-- Date/Time -->
            <p>Posted on XXXX</p>


            <hr>


            <!-- Post Content -->
            <p class=""lead"">Gamous ID: </p>


            <p>Burial Site ID: </p>


            <p>Burial Number: </p>


            <p>West to Head: </p>


            <p>West to Feet: </p>


            <p>South to Head: </p>


            <p>South to Feet: </p>


            <p>Burial Depth: </p>


            <p>Length: </p>


            <p>Goods: </p>


            <p>Year on Skull: </p>


            <p>Month on Skull: </p>


            <p>Date on Skull: </p>


            <p>Initals of Data Entry Expert: </p>


            <p>Initials of Data Entry Checker: </p>


            <p>BYU Sample: </p>


            <p>Body Analysis: </p>


            <p>Skull at Magazine: </p>


            <p>Postcrania at Magazine: </p>


            <p>Sex (Skull; 2018): </p>


            <p>Age (Skull; 2018): </p>


            <p>Rack and Shelf: </p>


            <p>TO BE CO");
            WriteLiteral(@"NFIRMED: </p>


            <p>Skull Trauma: </p>


            <p>Postcrania Trauma: </p>


            <p>Cribra Orbitala: </p>


            <p>Porotic Hyperostosis: </p>


            <p>Porotic Hyperostosis (LOCATIONS): </p>


            <p>Metopic Suture: </p>


            <p>Button Osteoma: </p>


            <p>Osteology Unknown Comment: </p>


            <p>Temporal Mandibular Joint Osteoarthritis (TMJ OA): </p>


            <p>Linear Hypoplasia Enamel: </p>


            <p>Year Excavated: </p>


            <p>Month Excavated: </p>


            <p>Date Excavated: </p>


            <p>Burial Preservation: </p>


            <p>Burial Wrapping: </p>


            <p>Burial Adult Child: </p>


            <p>Gender Code: </p>


            <p>Burial Gender Method: </p>


            <p>Age Code SINGLE: </p>


            <p>Burial Direction: </p>


            <p>Burial Age at Death: </p>


            <p>Burial Age Method: </p>


            <p>Hair Color Code: </p>


            <p>Burial Samp");
            WriteLiteral(@"le Taken: </p>


            <p>Length (M): </p>


            <p>Cluster: </p>


            <p>Face Bundle: </p>


            <p>Osteology Notes: </p>



            <!--<blockquote class=""blockquote"">
                <p class=""mb-0"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                <footer class=""blockquote-footer"">
                    Someone famous in
                    <cite title=""Source Title"">Source Title</cite>
                </footer>
            </blockquote>-->
            <!--<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Error, nostrum, aliquid, animi, ut quas placeat totam sunt tempora commodi nihil ullam alias modi dicta saepe minima ab quo voluptatem obcaecati?</p>


            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Harum, dolor quis. Sunt, ut, explicabo, aliquam tenetur ratione tempore quidem voluptates cupiditate voluptas illo saepe quaerat numquam recusandae? Qui, necessitatibus, est!</p>-->


");
            WriteLiteral("            <hr>\n\n\n            <!-- Comments Form -->\n            <div class=\"card my-4\">\n                <h5 class=\"card-header\">Leave a Comment:</h5>\n                <div class=\"card-body\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5840119745d358927cb71cebe7641e16bdc2b3010283", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <textarea class=""form-control"" rows=""3""></textarea>
                        </div>
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n\n\n            <!-- Single Comment -->\n            <div class=\"media mb-4\">\n                <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
            BeginWriteAttribute("alt", " alt=\"", 4485, "\"", 4491, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""media-body"">
                    <h5 class=""mt-0"">Jack Seal</h5>
                    Fag el Gamous is dope nasty yo!
                </div>
            </div>


            <!-- Comment with nested comments -->
            <div class=""media mb-4"">
                <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 4857, "\"", 4863, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""media-body"">
                    <h5 class=""mt-0"">Addison Howard</h5>
                    Might mess around and go eat some cashews,,, How bout that?


                    <div class=""media mt-4"">
                        <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 5186, "\"", 5192, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""media-body"">
                            <h5 class=""mt-0"">Trevi Fountain</h5>
                            Do it! Get it on video though,
                        </div>
                    </div>


                    <div class=""media mt-4"">
                        <img class=""d-flex mr-3 rounded-circle"" src=""http://placehold.it/50x50""");
            BeginWriteAttribute("alt", " alt=\"", 5568, "\"", 5574, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""media-body"">
                            <h5 class=""mt-0"">Jenna Weller</h5>
                            I'll just be in my breakout room, Let me know when it goes down in messages,
                        </div>
                    </div>


                </div>
            </div>


        </div>


        <!-- Sidebar Widgets Column -->
        <div class=""col-md-4"">


            <!-- Search Widget -->
            <div class=""card mb-4"">
                <h5 class=""card-header"">Search</h5>
                <div class=""card-body"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                        <span class=""inpug-group-append"">
                            <button class=""btn btn-secondary"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>


            <!-- Categories Widget -->
            <div cla");
            WriteLiteral(@"ss=""card my-4"">
                <h5 class=""card-header"">Categories</h5>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#"">This</a>
                                </li>
                                <li>
                                    <a href=""#"">for</a>
                                </li>
                                <li>
                                    <a href=""#"">different</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""col-lg-6"">
                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#"">is</a>
                                </li>
                                <li>
                            ");
            WriteLiteral(@"        <a href=""#"">the</a>
                                </li>
                                <li>
                                    <a href=""#"">categories</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>


            <!-- Side Widget -->
            <div class=""card my-4"">
                <h5 class=""card-header"">Side Widget</h5>
                <div class=""card-body"">
                    Photo time!
                </div>
            </div>


        </div>


    </div>
    <!-- /.row -->


</div>
<!-- /.container -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
