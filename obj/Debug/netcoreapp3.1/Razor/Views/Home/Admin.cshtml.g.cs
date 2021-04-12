#pragma checksum "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfaa2e50e4aad9801298be7cb6e7b42ace264748"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
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
#line 1 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/_ViewImports.cshtml"
using Intex2021FagElGamous.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfaa2e50e4aad9801298be7cb6e7b42ace264748", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7088af8761188d520fd6757092556a4fcfa0c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
  
    ViewData["Title"] = "Administration";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <main role=""main"" class=""pb-3"">
        <div class=""text-center"">
            <h1 class=""display-4"">Administration</h1>

            <style>
                .styled-table {
                    border-collapse: collapse;
                    margin: 25px 0;
                    font-size: 0.9em;
                    font-family: sans-serif;
                    min-width: 400px;
                    box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
                    width: 100%;
                }

                    .styled-table tbody tr {
                        border-bottom: 1px solid #bc9055;
                    }

                        .styled-table tbody tr:nth-of-type(even) {
                            background-color: #f3f3f3;
                        }

                        .styled-table tbody tr:last-of-type {
                            border-bottom: 2px solid #bc9055;
                        }

                    .styled-table th,
                    .styled-tab");
            WriteLiteral(@"le td {
                        padding: 12px 15px;
                    }

                    .styled-table thead tr {
                        background-color: #bc9055;
                        color: #ffffff;
                        text-align: left;
                    }
            </style>

            <table class=""styled-table"">
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Email</th>
                        <th>Role</th>
                        <th>Edit</th>
                        <th>Edit</th>
                        <th>Remove</th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 61 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                     foreach (var avm in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 64 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                       Write(avm.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 65 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                       Write(avm.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 66 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                       Write(avm.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 67 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                       Write(avm.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 68 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                         if (avm.Role == "Admin")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2295, "\"", 2363, 3);
            WriteAttributeValue("", 2305, "location.href=\'", 2305, 15, true);
#nullable restore
#line 71 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 2320, Url.Action("ChangeRoleNone", "Home", avm), 2320, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2362, "\'", 2362, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to None</button>\n                            </td>\n                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2516, "\"", 2590, 3);
            WriteAttributeValue("", 2526, "location.href=\'", 2526, 15, true);
#nullable restore
#line 74 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 2541, Url.Action("ChangeRoleResearcher", "Home", avm), 2541, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2589, "\'", 2589, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to Researcher</button>\n                            </td>\n");
#nullable restore
#line 76 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                        }
                        else if (avm.Role == "Researcher")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2860, "\"", 2928, 3);
            WriteAttributeValue("", 2870, "location.href=\'", 2870, 15, true);
#nullable restore
#line 80 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 2885, Url.Action("ChangeRoleNone", "Home", avm), 2885, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2927, "\'", 2927, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to None</button>\n                            </td>\n                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3081, "\"", 3150, 3);
            WriteAttributeValue("", 3091, "location.href=\'", 3091, 15, true);
#nullable restore
#line 83 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 3106, Url.Action("ChangeRoleAdmin", "Home", avm), 3106, 43, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3149, "\'", 3149, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to Admin</button>\n                            </td>\n");
#nullable restore
#line 85 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3385, "\"", 3459, 3);
            WriteAttributeValue("", 3395, "location.href=\'", 3395, 15, true);
#nullable restore
#line 89 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 3410, Url.Action("ChangeRoleResearcher", "Home", avm), 3410, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3458, "\'", 3458, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to Researcher</button>\n                            </td>\n                            <td>\n                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3618, "\"", 3687, 3);
            WriteAttributeValue("", 3628, "location.href=\'", 3628, 15, true);
#nullable restore
#line 92 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 3643, Url.Action("ChangeRoleAdmin", "Home", avm), 3643, 43, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3686, "\'", 3686, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Change to Admin</button>\n                            </td>\n");
#nullable restore
#line 94 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            <button class=\"btn btn-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3859, "\"", 3923, 3);
            WriteAttributeValue("", 3869, "location.href=\'", 3869, 15, true);
#nullable restore
#line 96 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
WriteAttributeValue("", 3884, Url.Action("RemoveUser", "Home", avm), 3884, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3922, "\'", 3922, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Remove</button>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 99 "/Users/trevorschmidt/Projects/Intex2021FagElGamous/Intex2021FagElGamous/Views/Home/Admin.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </main>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
