using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Telefone
    {
        [Key]
        public int Id_telefone { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone")]
        [StringLength(14, ErrorMessage = "Número incorreto", MinimumLength = 6)]
        public string Telefones { get; set; }
    }
}
