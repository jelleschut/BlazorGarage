#pragma checksum "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\UI\FormHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693f5a18c5a82fcc9007d3a3382adf6cfdd0f1bc"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Components.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.FormControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Domain.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
    public partial class FormHeader : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navbar navbar-form navbar-expand-sm bg-dark border box-shadow rounded flex-row justify-content-between");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-2 navbar-brand text-light");
            __builder.OpenElement(5, "b");
            __builder.AddContent(6, 
#nullable restore
#line 2 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\UI\FormHeader.razor"
                                                      Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", " btn-group pr-3");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "submit");
            __builder.AddAttribute(13, "class", "btn" + " " + (
#nullable restore
#line 4 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\UI\FormHeader.razor"
                                          ButtonType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 4 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\UI\FormHeader.razor"
                                                       ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\UI\FormHeader.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string ButtonText { get; set; }
    [Parameter]
    public string ButtonType { get; set; } = "btn-success";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591