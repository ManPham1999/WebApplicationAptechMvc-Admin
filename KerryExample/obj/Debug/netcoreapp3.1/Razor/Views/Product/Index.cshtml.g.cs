#pragma checksum "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b105e29b32f2ff60073809ab4461be224570a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b105e29b32f2ff60073809ab4461be224570a68", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63f30c00b1b4f791a0da8d6e5ebf5ba30268633", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KerryExample.Entity.ModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
  
    ViewData["Title"] = "User Managment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Quản Lý Kho Cà Phê</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b105e29b32f2ff60073809ab4461be224570a684596", async() => {
                WriteLiteral("Thêm mới sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
    <tr>
        <th>
            Hình ảnh
        </th>
        <th>
            Tên cà phê
        </th>
        <th>
            Giá cà phê
        </th>
        <th>
            Mô tả
        </th>
        <th>
            Số lượng tồn kho
        </th>
        <th>
            Trạng thái
        </th>
        <th>
            Loại cà phê
        </th>
        <th>Hành động</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
     foreach (var item in Model.products)
    {
        var chosenStyle = item.Status.Equals(true) ? "fas fa-check-square" : "fas fa-square";
        var chosenColor = item.Status.Equals(true) ? "color : green" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td >\n                <img");
            BeginWriteAttribute("src", " src=", 942, "", 956, 1);
#nullable restore
#line 47 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
WriteAttributeValue("", 947, item.Img, 947, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 956, "\"", 962, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"100px\" width=\"100px\">\n            </td>\n            <td >");
#nullable restore
#line 49 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td >");
#nullable restore
#line 50 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td >");
#nullable restore
#line 51 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
            Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td >");
#nullable restore
#line 52 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
            Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <i");
            BeginWriteAttribute("class", " class=\"", 1184, "\"", 1204, 1);
#nullable restore
#line 54 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
WriteAttributeValue("", 1192, chosenStyle, 1192, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1205, "\"", 1225, 1);
#nullable restore
#line 54 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
WriteAttributeValue("", 1213, chosenColor, 1213, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n            </td>\n            <td>");
#nullable restore
#line 56 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
           Write(item.Catgory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b105e29b32f2ff60073809ab4461be224570a689221", async() => {
                WriteLiteral("\n                    <button class=\"btn-success\" style=\"border-radius: 4px\">Chỉnh sửa</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
                                                               WriteLiteral(item.Id);

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
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b105e29b32f2ff60073809ab4461be224570a6811701", async() => {
                WriteLiteral("\n                    <button style=\"border-radius: 4px\" class=\"btn-danger\">Xóa</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
                                                                 WriteLiteral(item.Id);

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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 66 "/Users/macintoshhd/WebApplicationAptechMvc-Admin/KerryExample/Views/Product/Index.cshtml"
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
