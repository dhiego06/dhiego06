using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Documento
    {
        public long IdDocumento { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte[] Arquivo { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdRepresentante { get; set; }
        public long IdEdital { get; set; }

        public virtual Edital IdEditalNavigation { get; set; }
        public virtual Representante IdRepresentanteNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; }
    }
}
