using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaLogin
{
    class Pessoa
    {
        public int id { get; set; }
        public String nome { get; private set; }
        public String login { get; set; }
        public String senha { get; set; }

        public Pessoa(int id, String nome, String login, String senha)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }

        public override string ToString()
        {
            return this.login + "-" + this.senha;
        }
    }
}
