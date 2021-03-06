#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Vendas\Adicionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6ebb4be4aae3412e4af1dc6f5b946c0975cdea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UniBlazor.Client.Pages.Vendas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vendas/adicionar")]
    public partial class Adicionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Vendas\Adicionar.razor"
       
    Venda vendaProduto = new Venda();

    async Task AddVenda()
    {
        DateTime localDate = DateTime.Now;

        Venda venda = new Venda();

        venda.Cliente_Cpf = vendaProduto.Cliente_Cpf;
        venda.Data_venda = localDate;
        venda.Funcionario_Cpf = vendaProduto.Funcionario_Cpf;

        decimal total = 0;
        foreach (VendaProduto vendaProduto1 in vendaProduto.VendaProdutos)
        {
            total = decimal.Add(total, vendaProduto1.Valor);
        }
        venda.Valor_total = total;

        var response = await http.PostAsJsonAsync("api/venda", venda);
        var result = await response.Content.ReadAsStringAsync();

        var vendinha = await http.GetFromJsonAsync<Venda>($"api/venda/{Convert.ToInt32(result)}");

        List<VendaProduto> lista = new List<VendaProduto>();
        List<Produto> listaProd = new List<Produto>();

        foreach (VendaProduto vendaProduto2 in vendaProduto.VendaProdutos)
        {
            VendaProduto vendaP  = new VendaProduto
            {
                Produto_Id_produto = vendaProduto2.Produto_Id_produto,
                Quantidade = vendaProduto2.Quantidade,
                Valor = vendaProduto2.Valor,
                Valor_unitario = vendaProduto2.Valor_unitario,
                Venda_Id_venda = vendinha.Id_venda
            };

            var produto = await http.GetFromJsonAsync<Produto>($"api/produto/{vendaProduto2.Produto_Id_produto}");
            produto.Estoque_atual = produto.Estoque_atual - vendaProduto2.Quantidade;
            await http.PostAsJsonAsync("api/vendaProduto", vendaP);
            await http.PutAsJsonAsync("api/produto", produto);
        }

        navigation.NavigateTo("/vendas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
