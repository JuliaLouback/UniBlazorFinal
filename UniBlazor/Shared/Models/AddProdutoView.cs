using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class AddProdutoView
    {
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "Campo {0} é obrigatório")]
        [Display(Name = "Produto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Range(0, double.MaxValue, ErrorMessage = "Valores maiores que 0")]
        [Display(Name = "Quantidade")]

        public double Quantity { get; set; }

        [Display(Name = "Data")]
        public int Id_historico { get; set; }
    }
}
