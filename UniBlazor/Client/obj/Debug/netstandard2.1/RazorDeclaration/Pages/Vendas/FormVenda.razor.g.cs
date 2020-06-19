#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Vendas\FormVenda.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f39baaf5698ba64ab61277ffb090387938bda9"
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
    public partial class FormVenda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Vendas\FormVenda.razor"
      
    [Parameter] public Venda Venda { get; set; }

    [Parameter] public string ButtonText { get; set; }

    [Parameter] public EventCallback OnValidSubmit { get; set; }

    AddProdutoView addProdutoView = new AddProdutoView();

    List<VendaProduto> listaProdutos = new List<VendaProduto>();

    List<Cliente> Clientes = new List<Cliente>();

    List<Funcionario> Funcionarios = new List<Funcionario>();

    private string visao = "d-none";

    ElementReference MyCliente;
    ElementReference MyFuncionario;

    async Task AddProdutos()
    {
        var pesquisa = listaProdutos.Exists(x => x.Produto.Id_produto == addProdutoView.ProductId);
        if (pesquisa)
        {
            visao = "d-block";
        }
        else
        {
            var historico = await http.GetFromJsonAsync<List<Historico>>("api/historico");
            var pesquisas = historico.Where(x => x.Id_historico == addProdutoView.Id_historico).FirstOrDefault();

            VendaProduto venda = new VendaProduto();
            var produto = await http.GetFromJsonAsync<Produto>($"api/produto/{addProdutoView.ProductId}");
            venda.Produto = produto;
            venda.Produto_Id_produto = addProdutoView.ProductId;
            venda.Quantidade = Convert.ToInt32(addProdutoView.Quantity);
            venda.Valor_unitario = pesquisas.Valor;
            venda.Valor = decimal.Multiply(Convert.ToDecimal(pesquisas.Valor), Convert.ToDecimal(addProdutoView.Quantity));

            listaProdutos.Add(venda);

            Venda.VendaProdutos = listaProdutos;

            addProdutoView.ProductId = 0;
            addProdutoView.Quantity = 0;
            visao = "d-none";
        }

    }

    protected override async Task OnParametersSetAsync()
    {
        if (Venda.Id_venda != 0)
        {
            listaProdutos = await http.GetFromJsonAsync<List<VendaProduto>>($"api/vendaproduto/{Venda.Id_venda}");
            Venda.VendaProdutos = listaProdutos;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        Clientes = await http.GetFromJsonAsync<List<Cliente>>("api/cliente");
        Funcionarios = await http.GetFromJsonAsync<List<Funcionario>>("api/funcionario");

    }

    private void ExcluirProduto(int id)
    {
        listaProdutos.RemoveAll(x => x.Produto_Id_produto == id);
        Venda.VendaProdutos = listaProdutos;
    }


    protected async void SelectCliente()
    {
        await JSRuntime.InvokeVoidAsync("BlazorUni.setSelectCliente", MyCliente);
    }

    protected async void SelectFuncionario()
    {
        await JSRuntime.InvokeVoidAsync("BlazorUni.setSelectFuncionario", MyFuncionario);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
