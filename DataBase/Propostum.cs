using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Propostum
    {
        public Propostum()
        {
            DeclaracaoProposta = new HashSet<DeclaracaoPropostum>();
            Esclarecimentos = new HashSet<Esclarecimento>();
            Recursos = new HashSet<Recurso>();
        }

        public long IdProposta { get; set; }
        public DateTime? Validade { get; set; }
        public DateTime? PrazoPagamento { get; set; }
        public bool Garantia { get; set; }
        public byte[] CatalogoProduto { get; set; }
        public long IdEdital { get; set; }
        public bool Aceita { get; set; }
        public decimal ValorArremate { get; set; }
        public byte[] Ata { get; set; }
        public long? IdConcorrente { get; set; }
        public string MotivoPerdeu { get; set; }

        public virtual Concorrente IdConcorrenteNavigation { get; set; }
        public virtual ICollection<DeclaracaoPropostum> DeclaracaoProposta { get; set; }
        public virtual ICollection<Esclarecimento> Esclarecimentos { get; set; }
        public virtual ICollection<Recurso> Recursos { get; set; }
    }
}
