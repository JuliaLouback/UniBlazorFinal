using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class Fornecedor : IValidatableObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required(ErrorMessage = "CNPJ é obrigatório")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Nome da empresa é obrigatório")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Informe uma empresa válida")]
        [Display(Name = "Empresa")]
        [StringLength(80)]
        public string Nome_empresa { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [Display(Name = "E-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [StringLength(60)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inscrição Estadual é obrigatório")]
        [Display(Name = "Inscrição Estadual")]

        public string Inscricao_estadual { get; set; }

        [Required(ErrorMessage = "Inscrição Municipal é obrigatório")]
        [Display(Name = "Inscrição Municipal")]

        public long Inscricao_municipal { get; set; }

        /*[ForeignKey("Endereco_Id_endereco")]
        public Endereco Endereco { get; set; }

        public int Endereco_Id_endereco { get; set; }

    */
        [ForeignKey("Telefone")]
        public int Telefone_Id_telefone { get; set; }
        public Telefone Telefone { get; set; }

        [ForeignKey("Endereco")]
        public int Endereco_Id_Endereco { get; set; }
        public Endereco Endereco { get; set; }

        public Fornecedor()
        {
            Endereco = new Endereco();
            Telefone = new Telefone();
        }

        public string NomeResumido
        {
            get
            {
                if (string.IsNullOrEmpty(Nome_empresa))
                {
                    return null;
                }

                if (Nome_empresa.Length > 30)
                {
                    return Nome_empresa.Substring(0, 30) + "...";
                }
                else
                {
                    return Nome_empresa;
                }
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            string cnpj1;
            cnpj1 = Cnpj.Trim();
            cnpj1 = cnpj1.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj1.Length != 14)
                yield return new ValidationResult("Cnpj inválido");
            tempCnpj = cnpj1.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

        }
    }
}
