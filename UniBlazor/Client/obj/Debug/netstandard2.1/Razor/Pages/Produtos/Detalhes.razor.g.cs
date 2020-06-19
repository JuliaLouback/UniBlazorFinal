#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc53ab9de1a54174d7a81c29ac40a1f2be0dd4e4"
// <auto-generated/>
#pragma warning disable 1591
namespace UniBlazor.Client.Pages.Produtos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/produtos/detalhes/{id:int}")]
    public partial class Detalhes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-primary mb-2\">Detalhes Produtos</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<dt class=\"col-sm-2\">\r\n            Nome\r\n        </dt>\r\n        ");
            __builder.OpenElement(7, "dd");
            __builder.AddAttribute(8, "class", "col-sm-10");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#nullable restore
#line 14 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<dt class=\"col-sm-2\">\r\n            Unidade de Medida\r\n        </dt>\r\n        ");
            __builder.OpenElement(14, "dd");
            __builder.AddAttribute(15, "class", "col-sm-10");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddContent(17, 
#nullable restore
#line 20 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Unidade_medida

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<dt class=\"col-sm-2\">\r\n            Valor Unitário\r\n        </dt>\r\n        ");
            __builder.OpenElement(21, "dd");
            __builder.AddAttribute(22, "class", "col-sm-10");
            __builder.AddMarkupContent(23, "\r\n            R$  ");
            __builder.AddContent(24, 
#nullable restore
#line 26 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
                 produto.Valor_unitario

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<dt class=\"col-sm-2\">\r\n            Peso Bruto\r\n        </dt>\r\n        ");
            __builder.OpenElement(28, "dd");
            __builder.AddAttribute(29, "class", "col-sm-10");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddContent(31, 
#nullable restore
#line 32 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Peso_bruto

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddMarkupContent(34, "<dt class=\"col-sm-2\">\r\n            Peso Líquido\r\n        </dt>\r\n        ");
            __builder.OpenElement(35, "dd");
            __builder.AddAttribute(36, "class", "col-sm-10");
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddContent(38, 
#nullable restore
#line 38 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Peso_liquido

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<dt class=\"col-sm-2\">\r\n            Estoque Mínimo\r\n        </dt>\r\n        ");
            __builder.OpenElement(42, "dd");
            __builder.AddAttribute(43, "class", "col-sm-10");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddContent(45, 
#nullable restore
#line 44 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Estoque_minimo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<dt class=\"col-sm-2\">\r\n            Estoque Máximo\r\n        </dt>\r\n        ");
            __builder.OpenElement(49, "dd");
            __builder.AddAttribute(50, "class", "col-sm-10");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddContent(52, 
#nullable restore
#line 50 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Estoque_maximo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<dt class=\"col-sm-2\">\r\n            Estoque Atual\r\n        </dt>\r\n        ");
            __builder.OpenElement(56, "dd");
            __builder.AddAttribute(57, "class", "col-sm-10");
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.AddContent(59, 
#nullable restore
#line 56 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Estoque_atual

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.AddMarkupContent(62, "<dt class=\"col-sm-2\">\r\n            Descrição\r\n        </dt>\r\n        ");
            __builder.OpenElement(63, "dd");
            __builder.AddAttribute(64, "class", "col-sm-10");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.AddContent(66, 
#nullable restore
#line 62 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Descricao

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<dt class=\"col-sm-2\">\r\n            Fornecedor\r\n        </dt>\r\n        ");
            __builder.OpenElement(70, "dd");
            __builder.AddAttribute(71, "class", "col-sm-10");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.AddContent(73, 
#nullable restore
#line 68 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.Fornecedor_Cnpj

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.AddMarkupContent(76, "<dt class=\"col-sm-2\">\r\n            CFOP\r\n        </dt>\r\n        ");
            __builder.OpenElement(77, "dd");
            __builder.AddAttribute(78, "class", "col-sm-10");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.AddContent(80, 
#nullable restore
#line 74 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.CFOP_Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.AddMarkupContent(83, "<dt class=\"col-sm-2\">\r\n            CST\r\n        </dt>\r\n        ");
            __builder.OpenElement(84, "dd");
            __builder.AddAttribute(85, "class", "col-sm-10");
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.AddContent(87, 
#nullable restore
#line 80 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.CST_Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.AddMarkupContent(90, "<dt class=\"col-sm-2\">\r\n            NCM\r\n        </dt>\r\n        ");
            __builder.OpenElement(91, "dd");
            __builder.AddAttribute(92, "class", "col-sm-10");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.AddContent(94, 
#nullable restore
#line 86 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
             produto.NCM_Codigo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.OpenElement(99, "div");
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.OpenElement(101, "a");
            __builder.AddAttribute(102, "href", "/produtos/editar/" + (
#nullable restore
#line 91 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
                               produto.Id_produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "class", "btn btn-success");
            __builder.AddContent(104, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.AddMarkupContent(106, "<a href=\"/produtos\" class=\"btn btn-primary\">Voltar</a>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Produtos\Detalhes.razor"
       
    Produto produto = new Produto();
    [Parameter] public int id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        produto = await produtoRepository.GetProduto(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProdutoRepository produtoRepository { get; set; }
    }
}
#pragma warning restore 1591
