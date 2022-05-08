using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class OrdemCompra
    {
        public OrdemCompra()
        {
            NotaFiscals = new HashSet<NotaFiscal>();
        }

        public long IdOrdemCompra { get; set; }
        public long IdEdital { get; set; }
        public long IdItem { get; set; }
        public int Quantidade { get; set; }
        public string NumeroEmpenho { get; set; }
        public byte[] ArquivoEmpenho { get; set; }
        public DateTime PrazoEntrega { get; set; }
        public DateTime? NovoPrazo { get; set; }

        public virtual Edital IdEditalNavigation { get; set; }
        public virtual Item IdItemNavigation { get; set; }
        public virtual ICollection<NotaFiscal> NotaFiscals { get; set; }
    }
}
