using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class HistoricoSalario
    {
        [Key]
        public int Id_historicoSalario { get; set; }

        [Display(Name = "Data Início")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data_inicio { get; set; }

        [Display(Name = "Data Final")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime? Data_final { get; set; }

        [ForeignKey("Funcionario_Cpf")]
        public Funcionario Funcionario { get; set; }

        [Display(Name = "Funcionário")]
        public string Funcionario_Cpf { get; set; }

        [Display(Name = "Salário")]
        public string Salario { get; set; }

        public string Cargo { get; set; }
    }
}
