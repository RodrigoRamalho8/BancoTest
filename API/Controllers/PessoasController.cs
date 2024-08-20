using BancoTest;
using BancoTest.Infra;
using BancoTest.Servicos.DTOs;
using BancoTest.Servicos.Pessoa;
using BancoTest.Servicos.Pessoas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private ContextoBD _contextoBD;
        private CadastraPessoa _cadastraPessoa;
        
        public PessoasController(ContextoBD contextoBD, CadastraPessoa cadastraPessoa) 
        { 
            _cadastraPessoa = cadastraPessoa;
            _contextoBD = contextoBD;
        }
        [HttpGet("ObterTodos")]
        public IEnumerable<PessoaDTO> Get()
        {
            return _contextoBD.Pessoas.Select(pessoa => new PessoaDTO 
            { 
                PrimeiroNome = pessoa.PrimeiroNome, 
                Sobrenome = pessoa.Sobrenome, 
                CPF = pessoa.CPF,
                Email = pessoa.Email,
                Genero = pessoa.Genero
            });
        }
        [HttpGet("ObterPorCPF")]
        public PessoaDTO Get(string CPF)
        {
            //Terminar
            var pessoa = ObtemPessoaPorCPF.ObterPessoa
            return new PessoaDTO
            {
                PrimeiroNome = pessoa.PrimeiroNome, 
                Sobrenome = pessoa.Sobrenome, 
                CPF = pessoa.CPF,
                Email = pessoa.Email,
                Genero = pessoa.Genero
            };

        }

        [HttpPost]
        public IActionResult Add([FromBody]PessoaDTO pessoa)
        {
            _cadastraPessoa.Cadastrar(pessoa);
            return Ok();
        }
    }
}
