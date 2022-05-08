﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataBase
{
    public partial class Usuario
    {
        public Usuario()
        {
            Processos = new HashSet<Processo>();
            Representantes = new HashSet<Representante>();
        }

        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? ExpiraSenha { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; }

        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<Representante> Representantes { get; set; }
    }
}
