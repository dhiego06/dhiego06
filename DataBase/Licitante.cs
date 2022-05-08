using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Licitante
    {
        public Licitante()
        {
            Processos = new HashSet<Processo>();
        }

        public long IdLicitante { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
    }
}
