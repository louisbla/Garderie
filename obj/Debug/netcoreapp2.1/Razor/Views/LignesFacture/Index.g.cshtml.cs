#pragma checksum "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b51718213ccdd8255e0338bfe779d9d784c7ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LignesFacture_Index), @"mvc.1.0.view", @"/Views/LignesFacture/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LignesFacture/Index.cshtml", typeof(AspNetCore.Views_LignesFacture_Index))]
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
#line 1 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie;

#line default
#line hidden
#line 2 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/_ViewImports.cshtml"
using Garderie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b51718213ccdd8255e0338bfe779d9d784c7ed5", @"/Views/LignesFacture/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd06d82c8438d05622e08f6556b645a0b156553", @"/Views/_ViewImports.cshtml")]
    public class Views_LignesFacture_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Garderie.Models.LigneFacture>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ec1575e26448d68ed236913bc3fdcc", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 43, false);
#line 16 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalHt));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 44, false);
#line 19 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalTtc));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 44, false);
#line 22 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantite));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 43, false);
#line 25 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 51, false);
#line 28 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ObjetFacturable));

#line default
#line hidden
            EndContext();
            BeginContext(701, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(819, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(868, 42, false);
#line 37 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalHt));

#line default
#line hidden
            EndContext();
            BeginContext(910, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(966, 43, false);
#line 40 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalTtc));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1065, 43, false);
#line 43 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantite));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 42, false);
#line 46 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Visible));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1262, 68, false);
#line 49 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ObjetFacturable.ObjetFacturableId));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1386, 65, false);
#line 52 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1472, 71, false);
#line 53 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1564, 69, false);
#line 54 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "/Users/Katsuo/Code/VisualStudioProjects/Garderie/Garderie/Views/LignesFacture/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1672, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Garderie.Models.LigneFacture>> Html { get; private set; }
    }
}
#pragma warning restore 1591