using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Processo
    {
        public long IdProcesso { get; set; }
        public long IdUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacao { get; set; }
        public long IdSituacao { get; set; }
        public long IdLicitante { get; set; }
        public long IdTipoLicitacao { get; set; }
        public long IdTipoHabilitacao { get; set; }

        public virtual Licitante IdLicitanteNavigation { get; set; }
        public virtual SituacaoProcesso IdSituacaoNavigation { get; set; }
        public virtual TipoHabilitacao IdTipoHabilitacaoNavigation { get; set; }
        public virtual TipoLicitacao IdTipoLicitacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
