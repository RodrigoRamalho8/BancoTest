
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoTest.Infra;

namespace BancoTest.Servicos
{
    public class CadastraCliente
    {
        private readonly ContextoBD _contextoBD = new ContextoBD();
        public CadastraCliente() { }
        public Cliente CadastrarCliente(int agencia, string tipoConta, Pessoa pessoa)
        {
            var novoCliente = new Cliente(agencia, tipoConta, pessoa);
            return novoCliente;
        }
    }
}
