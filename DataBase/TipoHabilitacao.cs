using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class TipoHabilitacao
    {
        public TipoHabilitacao()
        {
            Processos = new HashSet<Processo>();
        }

        public long IdTipoHabilitacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
    }
}
