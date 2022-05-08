using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Concorrente
    {
        public Concorrente()
        {
            Esclarecimentos = new HashSet<Esclarecimento>();
            Proposta = new HashSet<Propostum>();
        }

        public long IdConcorrente { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public long IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<Esclarecimento> Esclarecimentos { get; set; }
        public virtual ICollection<Propostum> Proposta { get; set; }
    }
}
