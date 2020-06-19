using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Endereco
    {
        [Key]
        public int Id_endereco { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "CEP é obrigatório", AllowEmptyStrings = false)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Número é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Rua é obrigatório", AllowEmptyStrings = false)]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Informe uma rua válida")]
        [StringLength(60)]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório", AllowEmptyStrings = false)]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Informe um bairro válido")]
        [StringLength(45)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório", AllowEmptyStrings = false)]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Informe uma cidade válida")]
        [StringLength(45)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório", AllowEmptyStrings = false)]
        // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Informe um estado válido")]
        [StringLength(10)]
        public string Estado { get; set; }
    }
}
