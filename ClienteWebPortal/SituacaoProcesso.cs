using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class SituacaoProcesso
    {
        public SituacaoProcesso()
        {
            Processos = new HashSet<Processo>();
        }

        public long IdSituacao { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
    }
}
