
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoTest.Infra;
using BancoTest.Servicos.DTOs;

namespace BancoTest.Servicos.Cliente
{
    public class CadastraCliente
    {
        private readonly ContextoBD _contextoBD = new ContextoBD();
        private ObtemPessoaPorCPF _obtemPessoaPorCPF;
        public CadastraCliente(ObtemPessoaPorCPF obtemPessoaPorCPF)
        {
            _obtemPessoaPorCPF = obtemPessoaPorCPF;
        }
        public ClienteDTO CadastrarCliente(ObtemPessoaPorCPF obtemPessoaPorCPF, int agencia, string tipoConta, string CPF)
        {
            Pessoa pessoa = _obtemPessoaPorCPF.ObterPessoaPorCPF(CPF);
            var novoCliente = new Cliente(agencia, tipoConta, pessoa);
            return novoCliente;
        }
    }
}
