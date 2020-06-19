using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class CST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name = "CST")]
        [Required(ErrorMessage = "CST é obrigatório", AllowEmptyStrings = false)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return Codigo + " - " + Descricao;
            }
        }

        public string NomeResumido
        {
            get
            {
                if (string.IsNullOrEmpty(Descricao))
                {
                    return null;
                }

                if (Descricao.Length > 45)
                {
                    return Descricao.Substring(0, 45) + "...";
                }
                else
                {
                    return Descricao;
                }
            }
        }
    }
}
