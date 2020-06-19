#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\CST\Adicionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b895362011419921810cdc77b0f717cddac65b09"
// <auto-generated/>
#pragma warning disable 1591
namespace UniBlazor.Client.Pages.CST
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using UniBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using UniBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using UniBlazor.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using UniBlazor.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using UniBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FINAL\UniBlazor\UniBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cst/adicionar")]
    public partial class Adicionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-primary mb-4\">Adicionar CST</h3>\r\n\r\n");
            __builder.OpenComponent<UniBlazor.Client.Pages.CST.FormCST>(1);
            __builder.AddAttribute(2, "Cst", 
#nullable restore
#line 7 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\CST\Adicionar.razor"
               cst

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "ButtonText", "Adicionar");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\CST\Adicionar.razor"
                                                           AddCst

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\CST\Adicionar.razor"
       
    CST cst = new CST();

    async Task AddCst()
    {
        try
        {
            await cstRepository.CreateCst(cst);
        }
        catch(Exception ex)
        {

        }
        navigation.NavigateTo("/cst");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICstRepository cstRepository { get; set; }
    }
}
#pragma warning restore 1591
