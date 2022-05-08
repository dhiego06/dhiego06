using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Documentos = new HashSet<Documento>();
        }

        public long IdTipoDocumento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
