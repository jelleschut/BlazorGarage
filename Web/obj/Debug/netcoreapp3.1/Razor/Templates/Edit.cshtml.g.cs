#pragma checksum "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Templates\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aae00b0f945a6317a7064fb9e8943d4c07a5aad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_Edit), @"mvc.1.0.razor-page", @"/Templates/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aae00b0f945a6317a7064fb9e8943d4c07a5aad", @"/Templates/Edit.cshtml")]
    public class Templates_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Templates\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Car</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Car.CarId"" />
            <div class=""form-group"">
                <label asp-for=""Car.LicenseNumber"" class=""control-label""></label>
                <input asp-for=""Car.LicenseNumber"" class=""form-control"" />
                <span asp-validation-for=""Car.LicenseNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Car.Status"" class=""control-label""></label>
                <input asp-for=""Car.Status"" class=""form-control"" />
                <span asp-validation-for=""Car.Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<");
            WriteLiteral("div>\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Templates\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Templates.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Templates.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Templates.EditModel>)PageContext?.ViewData;
        public Web.Templates.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
