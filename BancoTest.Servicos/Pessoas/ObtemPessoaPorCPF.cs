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

        public PessoaDTO ObterPessoaPorCPF(string CPF) 
        {
            //Terminar
            new pessoadto = _contextoBD.Pessoas.Find(CPF);
            return
        }

    }
}
