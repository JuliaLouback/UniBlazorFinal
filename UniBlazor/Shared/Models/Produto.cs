using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Código é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Código deve ser númerico")]
        public int Id_produto { get; set; }

        [Required(ErrorMessage = "Nome do Produto", AllowEmptyStrings = false)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Informe um nome válido")]
        [Display(Name = "Nome")]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Valor Unitário")]
        [DataType(DataType.Currency)]
        [StringLength(10)]
        public string Valor_unitario { get; set; }

        [Required(ErrorMessage = "Unidade de medida é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Unidade de Medida")]
        [StringLength(60)]
        public string Unidade_medida { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Descrição do produto")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Estoque minimo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Estoque Mínimo")]
        [Range(1, 9999, ErrorMessage = "O valor mínimo deve ser {1}")]
        public long Estoque_minimo { get; set; }

        [Required(ErrorMessage = "Estoque maximo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Estoque Máximo")]
        [Range(1, 9999, ErrorMessage = "O valor mínimo deve ser {1}")]
        public long Estoque_maximo { get; set; }

        [Required(ErrorMessage = "Estoque atual", AllowEmptyStrings = false)]
        [Range(0, 9999, ErrorMessage = "O valor mínimo deve ser {1}")]
        [Display(Name = "Estoque Atual")]
        public long Estoque_atual { get; set; }

        [Required(ErrorMessage = "Valor inválio", AllowEmptyStrings = false)]
        [Display(Name = "Peso Bruto")]

        public string Peso_bruto { get; set; }

        [Required(ErrorMessage = "Valor inválio", AllowEmptyStrings = false)]
        [Display(Name = "Peso Líquido")]

        public string Peso_liquido { get; set; }

        [ForeignKey("Fornecedor_Cnpj")]
        public Fornecedor Fornecedor { get; set; }
        [Display(Name = "Fornecedor")]
        public string Fornecedor_Cnpj { get; set; }

        [ForeignKey("CST_Codigo")]
        public CST CST { get; set; }
        [Display(Name = "CST")]
        public string CST_Codigo { get; set; }

        [ForeignKey("NCM_Codigo")]
        public NCM NCM { get; set; }
        [Display(Name = "NCM")]
        public long NCM_Codigo { get; set; }

        [ForeignKey("CFOP_Codigo")]
        public CFOP CFOP { get; set; }
        [Display(Name = "CFOP")]
        public long CFOP_Codigo { get; set; }

        public string NomeResumido
        {
            get
            {
                if (string.IsNullOrEmpty(Nome))
                {
                    return null;
                }

                if (Nome.Length > 45)
                {
                    return Nome.Substring(0, 45) + "...";
                }
                else
                {
                    return Nome;
                }
            }
        }


    }
}
