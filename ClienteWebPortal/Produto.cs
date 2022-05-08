using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Produto
    {
        public Produto()
        {
            Items = new HashSet<Item>();
        }

        public long IdProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime Prazo { get; set; }
        public bool Garantia { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
