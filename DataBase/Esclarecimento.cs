using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Esclarecimento
    {
        public long IdEsclarecimento { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime? DataResposta { get; set; }
        public long IdRepresentante { get; set; }
        public long IdProposta { get; set; }
        public byte[] ArquivoResposta { get; set; }
        public long? IdConcorrente { get; set; }

        public virtual Concorrente IdConcorrenteNavigation { get; set; }
        public virtual Propostum IdPropostaNavigation { get; set; }
        public virtual Representante IdRepresentanteNavigation { get; set; }
    }
}
