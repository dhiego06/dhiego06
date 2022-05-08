using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Recurso
    {
        public long IdRecurso { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataLimite { get; set; }
        public byte[] Arquivo { get; set; }
        public bool Deferido { get; set; }
        public long IdProposta { get; set; }

        public virtual Propostum IdPropostaNavigation { get; set; }
    }
}
