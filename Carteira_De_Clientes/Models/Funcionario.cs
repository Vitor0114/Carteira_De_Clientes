using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carteira_De_Clientes.Models.Generic;

namespace Carteira_De_Clientes.Models
{

    public class Funcionario : CreateReadUpdateDelete<Funcionario>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Roles Role { get; set; }

        public Funcionario()
        {
        }
        public Funcionario(int id, string nome, string senha, string role)
        {
            this.Id = id;
            this.Nome = nome;
            this.Senha = senha;
            Role = (Roles)Enum.Parse(typeof(Roles), role);
        }
    }
}