#pragma checksum "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becac32a9f08ffb09887c46975b86422d78c8c06"
// <auto-generated/>
#pragma warning disable 1591
namespace UniBlazor.Client.Pages.HistoricoStatus
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/historicostatus")]
    public partial class Lista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-primary mb-4\">Lista de Histórico de Status</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                  filterHistoricoStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                                         Pesquisa

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row apagar");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-3 col-sm-12");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label>Data Inicial</label>\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateInputDate_0(__builder2, 16, 17, "form-control", 18, 
#nullable restore
#line 12 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                         filterHistoricoStatus.DataI

#line default
#line hidden
#nullable disable
                , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filterHistoricoStatus.DataI = __value, filterHistoricoStatus.DataI)), 20, () => filterHistoricoStatus.DataI);
                __builder2.AddMarkupContent(21, "\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateValidationMessage_1(__builder2, 22, 23, 
#nullable restore
#line 13 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                          () => filterHistoricoStatus.DataI

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-3 col-sm-12");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddMarkupContent(33, "<label>Data Final</label>\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateInputDate_2(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 19 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                         filterHistoricoStatus.DataF

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filterHistoricoStatus.DataF = __value, filterHistoricoStatus.DataF)), 38, () => filterHistoricoStatus.DataF);
                __builder2.AddMarkupContent(39, "\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateValidationMessage_3(__builder2, 40, 41, 
#nullable restore
#line 20 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                          () => filterHistoricoStatus.DataF

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-3 col-sm-12");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.AddMarkupContent(51, "<label>Cargo</label>\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateInputSelect_4(__builder2, 52, 53, "form-control", 54, 
#nullable restore
#line 26 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                           filterHistoricoStatus.Status

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => filterHistoricoStatus.Status = __value, filterHistoricoStatus.Status)), 56, () => filterHistoricoStatus.Status, 57, (__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n                    <option value></option>\r\n                    ");
                    __builder3.AddMarkupContent(59, "<option value=\"Ativo\">Ativo</option>\r\n                    ");
                    __builder3.AddMarkupContent(60, "<option value=\"Inativo\">Inativo</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(61, "\r\n                ");
                __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista.TypeInference.CreateValidationMessage_5(__builder2, 62, 63, 
#nullable restore
#line 31 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                          () => filterHistoricoStatus.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n        ");
                __builder2.AddMarkupContent(67, "<div class=\"col-md-1 col-sm-12 mt-1\">\r\n            <button type=\"submit\" class=\"btn btn-outline-secondary mt-4\">Pesquisar</button>\r\n        </div>\r\n        ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "col-md-1 col-sm-12 mt-1");
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-outline-primary mt-4");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                                                                                 Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(75, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenElement(80, "div");
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 45 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
     if (historicos == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "        ");
            __builder.AddMarkupContent(83, "<div class=\"alert alert-primary\" role=\"alert\">\r\n            Carregando...\r\n        </div> ");
#nullable restore
#line 49 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
               }
    else if (historicos.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "        ");
            __builder.AddMarkupContent(85, "<div class=\"alert alert-danger\" role=\"alert\">\r\n            Não existem dados cadastrados nessa tabela!\r\n        </div>\r\n");
#nullable restore
#line 55 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "        ");
            __builder.OpenElement(87, "table");
            __builder.AddAttribute(88, "class", "table table-responsive-sm table-striped");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.AddMarkupContent(90, @"<thead>
                <tr>
                    <th>
                        Data Início
                    </th>
                    <th>
                        Data Final
                    </th>
                    <th>
                        Funcionário
                    </th>
                    <th>
                        Status
                    </th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(91, "tbody");
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 76 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                 foreach (var item in historicos)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                    ");
            __builder.OpenElement(94, "tr");
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "td");
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.AddContent(98, 
#nullable restore
#line 80 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                             item.Data_inicio

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "td");
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.AddContent(103, 
#nullable restore
#line 83 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                             item.Data_final

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "td");
            __builder.AddMarkupContent(107, "\r\n                            ");
            __builder.AddContent(108, 
#nullable restore
#line 86 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                             item.Funcionario.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenElement(111, "td");
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.AddContent(113, 
#nullable restore
#line 89 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                             item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
#nullable restore
#line 92 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
#nullable restore
#line 94 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\FINAL\UniBlazor\UniBlazor\Client\Pages\HistoricoStatus\Lista.razor"
       
    List<HistoricoStatus> historicos;
    FilterHistoricoStatus filterHistoricoStatus = new FilterHistoricoStatus();


    protected override async Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        historicos = await historicoStatusRepository.GetHistoricoStatus();
    }

    private async Task Pesquisa()
    {
        historicos = await historicoStatusRepository.GetHistoricoStatusFilter(filterHistoricoStatus);
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
    }
}
namespace __Blazor.UniBlazor.Client.Pages.HistoricoStatus.Lista
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
