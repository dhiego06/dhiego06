using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Item
    {
        public Item()
        {
            OrdemCompras = new HashSet<OrdemCompra>();
        }

        public long IdItem { get; set; }
        public string Item1 { get; set; }
        public string Lote { get; set; }
        public string Descricao { get; set; }
        public long IdTipoItem { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? ValorVenda { get; set; }
        public byte[] Imgem { get; set; }
        public long IdProduto { get; set; }

        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual TipoItem IdTipoItemNavigation { get; set; }
        public virtual ICollection<OrdemCompra> OrdemCompras { get; set; }
    }
}
