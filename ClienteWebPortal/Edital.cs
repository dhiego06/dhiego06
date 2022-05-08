using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Edital
    {
        public Edital()
        {
            ArquivoEditals = new HashSet<ArquivoEdital>();
            Contratos = new HashSet<Contrato>();
            Documentos = new HashSet<Documento>();
            OrdemCompras = new HashSet<OrdemCompra>();
        }

        public long IdEdital { get; set; }
        public string Numero { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataDisputa { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataImpugnacao { get; set; }
        public int? RegistroPrecoMeses { get; set; }
        public bool Seguro { get; set; }
        public int IdSituacao { get; set; }
        public long IdRepresentante { get; set; }
        public DateTime Validade { get; set; }
        public DateTime? PrazoPagamento { get; set; }
        public string Observacao { get; set; }
        public string AnaliseUm { get; set; }
        public string AnaliseDois { get; set; }

        public virtual Representante IdRepresentanteNavigation { get; set; }
        public virtual SituacaoEdital IdSituacaoNavigation { get; set; }
        public virtual ICollection<ArquivoEdital> ArquivoEditals { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<OrdemCompra> OrdemCompras { get; set; }
    }
}
