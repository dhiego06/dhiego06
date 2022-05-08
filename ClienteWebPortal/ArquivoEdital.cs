using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class ArquivoEdital
    {
        public long IdArquivo { get; set; }
        public string Descricao { get; set; }
        public byte[] Arquivo { get; set; }
        public long IdEdital { get; set; }

        public virtual Edital IdEditalNavigation { get; set; }
    }
}
