#pragma checksum "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "289fb645f9af0e5d42effb3d273c62469fdc91ee"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages.Car
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
using Web.Components.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.FormControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Components.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using Web.Services.Interfaces;

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
#nullable restore
#line 19 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\_Imports.razor"
using DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Car")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Car/{id:int}")]
    public partial class Car : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "<h1>Car</h1>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-info offset-11 mb-3");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
                                                          Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, 
#nullable restore
#line 7 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
                                                                   text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
 if (showList)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Web.Components.Lists.CarList>(7);
            __builder.AddAttribute(8, "DetailsCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
                              Details

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Web.Pages.Car.Car.TypeInference.CreateCascadingValue_0(__builder, 9, 10, 
#nullable restore
#line 17 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
                           Id

#line default
#line hidden
#nullable disable
            , 11, (__builder2) => {
                __builder2.OpenComponent<Web.Components.Form.CarForm>(12);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 20 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Car\Car.razor"
       
    [Parameter]
    public int Id { get; set; }

    private bool showList;

    private string text;

    protected override void OnInitialized()
    {
        if(Id == 0)
        {
            showList = true;
        }

        text = Id == 0 ? "New" : "List";
    }

    public void Toggle()
    {
        showList = !showList;
        text = showList ? "New" : "List";
        if (!showList)
        {
            Id = 0;
        }
    }

    public void Details(int id)
    {
        Toggle();
        Id = id;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Web.Pages.Car.Car
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591