using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniBlazor.Shared.Models
{
    public class CotacaoProduto
    {
        [Key]
        public int Id_vendaProduto { get; set; }
        public int Quantidade { get; set; }
        public string Valor_unitario { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }

        [ForeignKey("Cotacao_Id_cotacao")]
        public Cotacao Cotacao { get; set; }

        public int Cotacao_Id_cotacao { get; set; }

        [ForeignKey("Produto_Id_produto")]
        public Produto Produto { get; set; }

        public int Produto_Id_produto { get; set; }
    }
}
