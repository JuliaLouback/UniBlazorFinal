using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UniBlazor.Shared.DTOs
{
    public class FilterProduto
    {
        public string Nome { get; set; }

        public DateTime? DataI { get; set; }

        public DateTime? DataF { get; set; }

        public string Descricao { get; set; }
    }
}
