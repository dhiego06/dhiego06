using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class TipoItem
    {
        public TipoItem()
        {
            Items = new HashSet<Item>();
        }

        public long IdTipoItem { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
