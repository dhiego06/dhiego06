using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class DeclaracaoPropostum
    {
        public long IdDeclaracao { get; set; }
        public string Texto { get; set; }
        public byte[] Arquivo { get; set; }
        public long IdProposta { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual Propostum IdPropostaNavigation { get; set; }
    }
}
