#pragma checksum "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0a03c43038c317936af064beaa404187ecfdff"
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
#line 1 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0a03c43038c317936af064beaa404187ecfdff", @"/Views/Home/ViewMummy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7088af8761188d520fd6757092556a4fcfa0c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMummy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewBurialViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- Page Content -->\n<div class=\"container\">\n\n    <!-- Page Heading/Breadcrumbs -->\n   <h1 class=\"mt-4 mb-3\">");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                    Write(Model.BurialSite.Ns);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.BurialSite.Nstop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                 Write(Model.BurialSite.Nsbottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                                            Write(Model.BurialSite.Ew);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                                                                 Write(Model.BurialSite.Ewtop);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                                                                                         Write(Model.BurialSite.Ewbottom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" #");
#nullable restore
#line 11 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                                                                                                                     Write(Model.Burial.BurialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <div class=""row"">
        <!-- Post Content Column -->
        <div class=""col-lg-8"">

            <!-- Post Content -->
            <div class=""mb-4"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingOne"">
                        <h5 class=""text-secondary"">
                            <a data-toggle=""collapse text-secondary"" data-parent=""#accordion"" href=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">Burial Site Location: </a>
                        </h5>
                    </div>


                    <div id=""collapseOne"" class=""collapse show"" role=""tabpanel"" aria-labelledby=""headingOne"">
                        <div class=""card-body"">
                            <p>Gamous ID: ");
#nullable restore
#line 29 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                     Write(Model.Burial.Gamous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Site ID: ");
#nullable restore
#line 30 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.BurialSiteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Number: ");
#nullable restore
#line 31 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.BurialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>West to Head: ");
#nullable restore
#line 32 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                        Write(Model.Burial.BurialWestToHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>West to Feet: ");
#nullable restore
#line 33 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                        Write(Model.Burial.BurialWestToFeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>South to Head: ");
#nullable restore
#line 34 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.BurialSouthToHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>South to Feet: ");
#nullable restore
#line 35 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.BurialSouthToFeet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Depth: ");
#nullable restore
#line 36 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                        Write(Model.Burial.BurialDepth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Direction: ");
#nullable restore
#line 37 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                            Write(Model.Burial.BurialDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Osteology Notes: ");
#nullable restore
#line 38 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                           Write(Model.Burial.OsteologyNotes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingTwo"">
                        <h5 class=""mb-0"">
                            <a class=""collapsed text-secondary"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                Burial Info
                            </a>
                        </h5>
                    </div>
                    <div id=""collapseTwo"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingTwo"">
                        <div class=""card-body"">
                            <p>Burial Preservation: ");
#nullable restore
#line 52 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                               Write(Model.Burial.BurialPreservation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Goods: ");
#nullable restore
#line 53 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                 Write(Model.Burial.Goods);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Wrapping: ");
#nullable restore
#line 54 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                           Write(Model.Burial.BurialWrapping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Adult Child: ");
#nullable restore
#line 55 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                              Write(Model.Burial.BurialAdultChild);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Age Method: ");
#nullable restore
#line 56 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                             Write(Model.Burial.Burialagemethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Age at Death: ");
#nullable restore
#line 57 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                               Write(Model.Burial.Burialageatdeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Burial Sample Taken: ");
#nullable restore
#line 58 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                               Write(Model.Burial.Burialsampletaken);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Length (M): ");
#nullable restore
#line 59 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                      Write(Model.Burial.LengthM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Cluster: ");
#nullable restore
#line 60 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                   Write(Model.Burial.Cluster);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Face Bundle: ");
#nullable restore
#line 61 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                       Write(Model.Burial.FaceBundle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingThree"">
                        <h5 class=""mb-0"">
                            <a class=""collapsed text-secondary"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">Skull Info</a>
                        </h5>
                    </div>
                    <div id=""collapseThree"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingThree"">
                        <div class=""card-body"">
                            <p>Skull at Magazine: ");
#nullable restore
#line 73 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                             Write(Model.Burial.SkullAtMagazine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Skull Trauma: ");
#nullable restore
#line 74 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                        Write(Model.Burial.SkullTrauma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Cribra Orbitalia: ");
#nullable restore
#line 75 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                            Write(Model.Burial.CribraOrbitala);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Porotic Hyperostosis: ");
#nullable restore
#line 76 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                Write(Model.Burial.PoroticHyperostosis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Porotic Hyperostosis (LOCATIONS): ");
#nullable restore
#line 77 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                            Write(Model.Burial.PoroticHyperostosisLocations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Metopic Suture: ");
#nullable restore
#line 78 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.MetopicSuture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Temporomandibular Joint Osteoarthritis (TMJ OA): ");
#nullable restore
#line 79 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                                           Write(Model.Burial.Tmjoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Linear Hypoplasia Enamel: ");
#nullable restore
#line 80 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                    Write(Model.Burial.LinearHypoplasiaEnamel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingFour"">
                        <h5 class=""mb-0"">
                            <a class=""collapsed text-secondary"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">Body Info</a>
                        </h5>
                    </div>
                    <div id=""collapseFour"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingFour"">
                        <div class=""card-body"">
                            <p>Length: ");
#nullable restore
#line 92 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                  Write(Model.Burial.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Age Code SINGLE: ");
#nullable restore
#line 93 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                           Write(Model.Burial.AgeCodeSingle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Body Analysis: ");
#nullable restore
#line 94 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.BodyAnalysis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Postcrania at Magazine: ");
#nullable restore
#line 95 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                  Write(Model.Burial.PostcraniaAtMagazine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Sex (Skull; 2018): ");
#nullable restore
#line 96 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                             Write(Model.Burial.SexSkull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Age (Skull; 2018): ");
#nullable restore
#line 97 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                             Write(Model.Burial.AgeSkull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Postcrania Trauma: ");
#nullable restore
#line 98 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                             Write(Model.Burial.PostcraniaTrauma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Gender Code: ");
#nullable restore
#line 99 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                       Write(Model.Burial.GenderCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Hair Color Code: ");
#nullable restore
#line 100 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                           Write(Model.Burial.HairColorCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>


                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingFive"">
                        <h5 class=""mb-0"">
                            <a class=""collapsed text-secondary"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseFive"" aria-expanded=""false"" aria-controls=""collapseFive"">Dating Info</a>
                        </h5>
                    </div>
                    <div id=""collapseFive"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingFive"">
                        <div class=""card-body"">
                            <p>Year on Skull: ");
#nullable restore
#line 114 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.YearOnSkull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Month on Skull: ");
#nullable restore
#line 115 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.MonthOnSkull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Date on Skull: ");
#nullable restore
#line 116 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                         Write(Model.Burial.DateOnSkull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Year Excavated: ");
#nullable restore
#line 117 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.YearExcav);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Month Excavated: ");
#nullable restore
#line 118 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                           Write(Model.Burial.MonthExcavated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Date Excavated: ");
#nullable restore
#line 119 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.DateExcavated);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" role=""tab"" id=""headingSix"">
                        <h5 class=""text-secondary"">
                            <a class=""collapsed text-secondary"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseSix"" aria-expanded=""false"" aria-controls=""collapseSix"">Other Notes</a>
                        </h5>
                    </div>
                    <div id=""collapseSix"" class=""collapse"" role=""tabpanel"" aria-labelledby=""headingSix"">
                        <div class=""card-body"">
                            <p>Initals of Data Entry Expert: ");
#nullable restore
#line 131 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                        Write(Model.Burial.InitialsOfDataEntryExpert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Initials of Data Entry Checker: ");
#nullable restore
#line 132 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                                          Write(Model.Burial.InitialsOfDataEntryChecker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>BYU Sample: ");
#nullable restore
#line 133 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                      Write(Model.Burial.ByuSample);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Rack and Shelf: ");
#nullable restore
#line 134 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
                                          Write(Model.Burial.RackandShelf);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <!-- Sidebar Widgets Column -->
        <div class=""col-md-4"">

            <!-- Search Widget -->
            <div class=""card mb-4"">
                <h5 class=""card-header"">Display Images/Files</h5>
                <div class=""card-body"">
                </div>
            </div>

            <!-- Categories Widget -->
            <div class=""card my-4"">
                <div class=""card-body text-center"">
                    <h3>Want To Edit This Record?</h3>
                </div>
                <button type=""submit"" class=""btn button1 right btn-Dark""");
            BeginWriteAttribute("onclick", " onclick=\"", 8909, "\"", 8974, 3);
            WriteAttributeValue("", 8919, "location.href=\'", 8919, 15, true);
#nullable restore
#line 157 "/Users/addisonhoward/Documents/Winter 2021/IS 413/newnewintex/Intex2021FagElGamous/Views/Home/ViewMummy.cshtml"
WriteAttributeValue("", 8934, Url.Action("EditMummy", "Home", Model), 8934, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8973, "\'", 8973, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit &rarr;</button>\n            </div>\n            </div>\n\n        </div>\n    </div>\n    <!-- /.row -->\n</div>\n<!-- /.container -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewBurialViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
