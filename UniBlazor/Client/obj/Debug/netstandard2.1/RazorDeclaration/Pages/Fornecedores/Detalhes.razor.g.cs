#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Fornecedores\Detalhes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4458cca02b3ea9a2e1660d526e4becb8f45a042c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UniBlazor.Client.Pages.Fornecedores
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fornecedores/detalhes/{id:int}")]
    public partial class Detalhes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Fornecedores\Detalhes.razor"
       
    Fornecedor fornecedor = new Fornecedor();
    [Parameter] public int id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        fornecedor = await fornecedorRepository.GetFornecedor(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFornecedorRepository fornecedorRepository { get; set; }
    }
}
#pragma warning restore 1591
