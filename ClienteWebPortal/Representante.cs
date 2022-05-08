using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Representante
    {
        public Representante()
        {
            Documentos = new HashSet<Documento>();
            Editals = new HashSet<Edital>();
            Esclarecimentos = new HashSet<Esclarecimento>();
        }

        public long IdRepresentante { get; set; }
        public DateTime DataCadastro { get; set; }
        public long IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Edital> Editals { get; set; }
        public virtual ICollection<Esclarecimento> Esclarecimentos { get; set; }
    }
}
