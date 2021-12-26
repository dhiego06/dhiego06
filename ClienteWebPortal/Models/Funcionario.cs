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
}
