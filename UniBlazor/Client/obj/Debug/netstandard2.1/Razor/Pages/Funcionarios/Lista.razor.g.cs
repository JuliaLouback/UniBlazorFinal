#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9aa1fb9450e8ff76401303cfe04245b824a28de"
// <auto-generated/>
#pragma warning disable 1591
namespace UniBlazor.Client.Pages.Funcionarios
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios")]
    public partial class Lista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-primary mb-4\">Lista de Funcionários</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"/funcionarios/adicionar\" class=\"btn btn-outline-success mb-4\">Adicionar</a>\r\n</div>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                  filterFuncionario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                     Pesquisa

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row apagar");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-4 col-sm-12");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<label>Nome</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                         filterFuncionario.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filterFuncionario.Nome = __value, filterFuncionario.Nome))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => filterFuncionario.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __Blazor.UniBlazor.Client.Pages.Funcionarios.Lista.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 21 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                          () => filterFuncionario.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-md-4 col-sm-12");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.AddMarkupContent(34, "<label>CPF</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "id", "cpf");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                         filterFuncionario.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filterFuncionario.Cpf = __value, filterFuncionario.Cpf))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => filterFuncionario.Cpf));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __Blazor.UniBlazor.Client.Pages.Funcionarios.Lista.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 28 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                          () => filterFuncionario.Cpf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<div class=\"col-md-1 col-sm-12 mt-1\">\r\n            <button type=\"submit\" class=\"btn btn-outline-secondary mt-4\">Pesquisar</button>\r\n        </div>\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-md-1 col-sm-12 mt-1");
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "class", "btn btn-outline-primary mt-4");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                                                 Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "alert alert-danger alert-dismissible");
            __builder.AddAttribute(62, "role", "alert");
            __builder.AddAttribute(63, "style", "display:none");
            __builder.AddElementReferenceCapture(64, (__value) => {
#nullable restore
#line 40 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                                                          MyAlert = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(65, "\r\n    O funcionário ");
            __builder.AddMarkupContent(66, "<strong>não</strong> pode ser excluído pois esta vinculado a uma ou mais Vendas e/ou Cotações!\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n");
            __builder.OpenElement(68, "div");
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 45 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
     if (funcionarios == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "        ");
            __builder.AddMarkupContent(71, "<div class=\"alert alert-primary\" role=\"alert\">\r\n            Carregando...\r\n        </div> ");
#nullable restore
#line 49 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
               }
    else if (funcionarios.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "        ");
            __builder.AddMarkupContent(73, "<div class=\"alert alert-danger\" role=\"alert\">\r\n            Não existem dados cadastrados nessa tabela!\r\n        </div> ");
#nullable restore
#line 54 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
               }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.OpenElement(75, "table");
            __builder.AddAttribute(76, "class", "table table-responsive-sm table-striped");
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.AddMarkupContent(78, @"<thead>
                <tr>
                    <th>
                        Nome
                    </th>
                    <th>
                        E-mail
                    </th>
                    <th>
                        CPF
                    </th>
                    <th>
                        Cargo
                    </th>
                    <th>

                    </th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(79, "tbody");
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 78 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                 foreach (var item in funcionarios)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "                    ");
            __builder.OpenElement(82, "tr");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "td");
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.AddContent(86, 
#nullable restore
#line 82 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                             item.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.OpenElement(89, "td");
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.AddContent(91, 
#nullable restore
#line 85 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                             item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "td");
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.AddContent(96, 
#nullable restore
#line 88 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                             item.Cpf

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "td");
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.AddContent(101, 
#nullable restore
#line 91 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                             item.Cargo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n                        ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "class", "apagar");
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "a");
            __builder.AddAttribute(108, "href", "/funcionarios/editar/" + (
#nullable restore
#line 95 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                           item.Cpf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "class", "btn btn-warning");
            __builder.AddContent(110, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "href", "/funcionarios/detalhes/" + (
#nullable restore
#line 96 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                             item.Cpf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "class", "btn btn-info");
            __builder.AddContent(115, "Detalhes");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                            ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-danger");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                                                                       () => ExcluirFuncionario(item.Cpf)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(120, "Excluir");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 100 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.CloseElement();
#nullable restore
#line 102 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\Funcionarios\Lista.razor"
       
    List<Funcionario> funcionarios;
    FilterFuncionario filterFuncionario = new FilterFuncionario();
    ElementReference MyAlert;


    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        funcionarios = await funcionarioRepository.GetFuncionario();
    }

    private async Task ExcluirFuncionario(string id)
    {
        var funcionario = await funcionarioRepository.GetFuncionario(id);

        try
        {
            await JSRuntime.InvokeVoidAsync("BlazorVisao.setVisaoB", MyAlert);


            await historicoSalarioRepository.DeleteHistoricoSalario(funcionario.Cpf);
            await historicoStatusRepository.DeleteHistoricoStatus(funcionario.Cpf);
            await telefoneRepository.DeleteTelefone(funcionario.Telefone_Id_telefone);
            await enderecoRepository.DeleteEndereco(funcionario.Endereco_Id_endereco);
            await LoadData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            await JSRuntime.InvokeVoidAsync("BlazorVisao.setVisao", MyAlert);

        }
    }
    private async Task Pesquisa()
    {
        funcionarios = await funcionarioRepository.GetFuncionarioFilter(filterFuncionario);
    }

    private async Task Imprimir()
    {
        await JSRuntime.InvokeVoidAsync("BlazorImprimir.setImprimir");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHistoricoStatusRepository historicoStatusRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHistoricoSalarioRepository historicoSalarioRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEnderecoRepository enderecoRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITelefoneRepository telefoneRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFuncionarioRepository funcionarioRepository { get; set; }
    }
}
namespace __Blazor.UniBlazor.Client.Pages.Funcionarios.Lista
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
