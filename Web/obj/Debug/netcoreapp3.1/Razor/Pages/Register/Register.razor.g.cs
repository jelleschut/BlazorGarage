#pragma checksum "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0634cefb73f1a87386028c6acf0dbd9f02dd520"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages.Register
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
 if (data != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
     foreach (string s in data)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
         s

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
          
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 9 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
     data

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
         
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<Web.Components.Form.CarForm>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Web.Components.Form.OwnerForm>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<Web.Components.Form.MaintenanceForm>(7);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\SCHUB05\Documents\InfoSupport\Projects\Blok1Opdracht\BeunHaasGarageV2\Web\Pages\Register\Register.razor"
       
    private string[] data;
    private TestClass TestClass = new TestClass();

    protected override async Task OnInitializedAsync()

    {

        data = await TestClass.GetAllData();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
