using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteWebPortal
{
    public partial class Empresa
    {
        public Empresa()
        {
            Concorrentes = new HashSet<Concorrente>();
        }

        public long IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Concorrente> Concorrentes { get; set; }
    }
}
