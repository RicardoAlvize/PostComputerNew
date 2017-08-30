using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb.Models
{
    public class Cadastro
    {
        public int Id{ get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public int Cpf { get; set; }

        public int Telefone { get; set; }
    }
}