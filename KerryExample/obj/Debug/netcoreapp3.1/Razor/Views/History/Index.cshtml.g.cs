#pragma checksum "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc9907c1f2b26cfe838d3a00dfb261faaf750bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_History_Index), @"mvc.1.0.view", @"/Views/History/Index.cshtml")]
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
#line 1 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/_ViewImports.cshtml"
using KerryExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/_ViewImports.cshtml"
using KerryExample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc9907c1f2b26cfe838d3a00dfb261faaf750bb", @"/Views/History/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63f30c00b1b4f791a0da8d6e5ebf5ba30268633", @"/Views/_ViewImports.cshtml")]
    public class Views_History_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KerryExample.Entity.ModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
  
    ViewData["Title"] = "User Managment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Quản Lý lịch sử giao dịch</h1>

<table class=""table"">
    <thead>
    <tr>
        <th>
                    Email người mua
                </th>
        <th>
            Ngày thanh toán
        </th>
        <th>
            Tổng tiền
        </th>

        <th>
            Tình trạng
        </th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
     foreach (var item in Model.transactions)
    {
        var type = item.CardType.Name == "Done" ? "Đã thanh toán" : item.CardType.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 33 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
           Write(item.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
           Write(type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 37 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/History/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KerryExample.Entity.ModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
