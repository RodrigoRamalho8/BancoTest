
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoTest.Infra;
using BancoTest.Servicos.DTOs;
using BancoTest.Servicos.Pessoas;

namespace BancoTest.Servicos.Cliente
{
    public class CadastraCliente
    {
        private readonly ContextoBD _contextoBD;
        private ObtemPessoaPorCPF _obtemPessoaPorCPF;
        public CadastraCliente(ContextoBD contextoBD, ObtemPessoaPorCPF obtemPessoaPorCPF)
        {
            _contextoBD = contextoBD;
            _obtemPessoaPorCPF = obtemPessoaPorCPF;
        }
        public void Cadastrar(ObtemPessoaPorCPF obtemPessoaPorCPF, int agencia, string tipoConta, string CPF)
        {
            Pessoa pessoadto = _obtemPessoaPorCPF.ObterPessoaPorCPF(CPF);
            var novoCliente = new BancoTest.Cliente(agencia, tipoConta, pessoadto);
            _contextoBD.Clientes.Add(novoCliente);
            _contextoBD.SaveChanges();
        }
    }
}
