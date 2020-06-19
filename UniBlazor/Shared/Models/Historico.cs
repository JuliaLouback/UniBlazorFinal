using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Historico
    {
        [Key]
        public int Id_historico { get; set; }

        [Display(Name = "Data Início")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data_inicio { get; set; }

        [Display(Name = "Data Final")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data_final { get; set; }

        [ForeignKey("Produto_Id_produto")]
        public Produto Produto { get; set; }
        public int Produto_Id_produto { get; set; }

        public string Valor { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return Data_inicio + " - R$ " + Valor;
            }
        }
    }
}
