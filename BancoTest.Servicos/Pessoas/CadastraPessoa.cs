using BancoTest.Infra;
using BancoTest.Servicos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest.Servicos.Pessoas
{

    public class CadastraPessoa
    {
        private ContextoBD _contextoBD;
        public CadastraPessoa(ContextoBD contextoBD)
        {
            _contextoBD = contextoBD;
        }
        public void Cadastrar(PessoaDTO pessoadto)
        {
            var novaPessoa = new BancoTest.Pessoa(pessoadto.PrimeiroNome, pessoadto.Sobrenome, pessoadto.CPF, pessoadto.Email, pessoadto.Genero);
            _contextoBD.Pessoas.Add(novaPessoa);
            _contextoBD.SaveChanges();
        }
    }
}
