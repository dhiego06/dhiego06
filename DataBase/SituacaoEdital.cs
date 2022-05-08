using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class SituacaoEdital
    {
        public SituacaoEdital()
        {
            Editals = new HashSet<Edital>();
        }

        public int IdSituacao { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<Edital> Editals { get; set; }
    }
}
