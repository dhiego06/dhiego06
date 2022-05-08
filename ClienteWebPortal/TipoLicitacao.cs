using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class TipoLicitacao
    {
        public TipoLicitacao()
        {
            Processos = new HashSet<Processo>();
        }

        public long IdTipoLicitacao { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
    }
}
