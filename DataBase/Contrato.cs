using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Contrato
    {
        public long IdContrato { get; set; }
        public string Numero { get; set; }
        public long IdEdital { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal Valor { get; set; }
        public byte[] ArquivoContrato { get; set; }
        public decimal? PercentualAditivado { get; set; }
        public decimal? NovoValor { get; set; }
        public byte[] ArquivoAditivo { get; set; }

        public virtual Edital IdEditalNavigation { get; set; }
    }
}
