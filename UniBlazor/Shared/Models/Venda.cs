using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Venda
    {
        [Key]
        public int Id_venda { get; set; }

        // [Required(ErrorMessage = "Data da Venda")]
        [Display(Name = "Data da Venda")]
        // [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Data_venda { get; set; }

        [Required(ErrorMessage = "Valor", AllowEmptyStrings = false)]
        [Display(Name = "Valor")]

        /*[Column(TypeName = "decimal(10, 2)")]
        public decimal Valor_frete { get; set; }*/

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor_total { get; set; }

        [ForeignKey("Funcionario_Cpf")]
        public Funcionario Funcionario { get; set; }

        [Display(Name = "Funcionário")]
        public string Funcionario_Cpf { get; set; }

        [ForeignKey("Cliente_Cpf")]
        public Cliente Cliente { get; set; }

        [Display(Name = "Cliente")]
        public string Cliente_Cpf { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; }

        public Venda()
        {
            VendaProdutos = new List<VendaProduto>();
        }
    }
}
