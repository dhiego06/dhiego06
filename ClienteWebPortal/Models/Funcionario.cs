using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ClienteWebPortal.Models
{
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataIngresso { get; set; }
    }

    public partial class NovoFuncionario: Funcionario
    {
        public int IdTipoLicitacao { get; set; }
        public List<TipoLicitacao> TipoLicitacao { get; set; }

        public int US_ID { get; set; }

        public List<DataBase.Data.Usuario> Funcionarios { get; set; }

    }

}
