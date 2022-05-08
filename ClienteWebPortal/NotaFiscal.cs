using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class NotaFiscal
    {
        public long IdNota { get; set; }
        public string Numero { get; set; }
        public DateTime Emissao { get; set; }
        public byte[] ArquivoNota { get; set; }
        public bool? Pagamento { get; set; }
        public long IdOrdemCompra { get; set; }

        public virtual OrdemCompra IdOrdemCompraNavigation { get; set; }
    }
}
