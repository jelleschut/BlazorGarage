#pragma checksum "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca9db02d1229b3039069f95af120af4c10c45bb"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Components.Lists
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
    public partial class OwnerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-striped table-hover table-sm");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<thead class=""thead-dark"">
        <tr class=""d-flex"">
            <th class=""col-2"">
                Name
            </th>
            <th class=""col-2"">
                City
            </th>
            <th class=""col-2"">
                <div class=""text-light font-weight-bold"">
                    Address
                </div>
            </th>
            <th class=""col-2"">
                    Zipcode
            </th>
            <th class=""col-2"">
                <div class=""text-light font-weight-bold"">
                    PhoneNumber
                </div>
            </th>
            <th class=""col-2"">
                <div class=""text-light font-weight-bold"">
                    Email
                </div>
            </th>
        </tr>
    </thead>
");
#nullable restore
#line 33 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
     if (Owners == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<Web.Components.UI.Spinner>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 36 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddAttribute(9, "class", "border");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 40 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
             foreach (var owner in Owners)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddAttribute(13, "class", "d-flex");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "class", "col-2");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddContent(18, 
#nullable restore
#line 44 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                     owner.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "class", "col-2");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddContent(24, 
#nullable restore
#line 47 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                     owner.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "col-2");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.AddContent(30, 
#nullable restore
#line 50 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                     owner.Street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.AddContent(32, 
#nullable restore
#line 50 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                                   owner.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "col-2");
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.AddContent(38, 
#nullable restore
#line 53 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                     owner.Zipcode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "col-2");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddContent(44, 
#nullable restore
#line 56 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                     owner.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "class", "col-2");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-sm btn-info");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
                                                                    async () => await DetailsCallback.InvokeAsync(owner.OwnerId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 62 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 64 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Components\Lists\OwnerList.razor"
       
    private IEnumerable<Owner> Owners { get; set; }

    [Parameter]
    public EventCallback<int> DetailsCallback { get; set; }

    protected async override Task OnInitializedAsync()
    {

        Owners = await OwnerRepository.GetAllAsync();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOwnerRepository OwnerRepository { get; set; }
    }
}
#pragma warning restore 1591