using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class TipoLicitacao
    {
        public long IdTipoLicitacao { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
    }
}
