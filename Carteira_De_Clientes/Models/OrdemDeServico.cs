using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carteira_De_Clientes.Models.Generic;

namespace Carteira_De_Clientes.Models
{
    public class OrdemDeServico : CreateReadUpdateDelete<OrdemDeServico>
    {
        public int Id { get; set; }
        public bool Done { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }

        public OrdemDeServico()
        {
        }

        public OrdemDeServico(bool done, int FuncionarioId, int servicoId)
        {
            this.Done = done;
            this.FuncionarioId = FuncionarioId;
            this.ServicoId = servicoId;
        }
    }
}
