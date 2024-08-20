using BancoTest.Infra;
using BancoTest.Servicos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest.Servicos.Pessoas
{
    public class ObtemPessoaPorCPF
    {
        private ContextoBD _contextoBD;

        public ObtemPessoaPorCPF(ContextoBD contextoBD) 
        {
            _contextoBD = contextoBD;
        }

        public Pessoa ObterPessoaPorCPF(string CPF) 
        {
            var pessoa = _contextoBD.Pessoas.Find(CPF);
            return pessoa;            
        }        
        public PessoaDTO ObterPessoaDTOPorCPF(string CPF) 
        {
            var pessoa = ObterPessoaPorCPF(CPF);
            return new PessoaDTO
            {
                PrimeiroNome = pessoa.PrimeiroNome,
                Sobrenome = pessoa.Sobrenome,
                CPF = pessoa.CPF,
                Email = pessoa.Email,
                Genero = pessoa.Genero
            };
        }

    }
}
