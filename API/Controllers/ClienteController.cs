using BancoTest.Infra;
using BancoTest.Servicos.Cliente;
using Microsoft.AspNetCore.Mvc;
using BancoTest.Servicos.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private ContextoBD _contextoBD;
        private CadastraCliente _cadastraCliente;

        public ClienteController(ContextoBD contextoBD, CadastraCliente cadastraCliente)
        {
            _contextoBD = contextoBD;
            _cadastraCliente = cadastraCliente;
        }

        [HttpGet("ObterTodos")]
        public IEnumerable<ClienteDTO> Get()
        {
            return _contextoBD.Clientes.Select(cliente => new ClienteDTO
            {
                Agencia = cliente.Agencia,
                TipoDeConta = cliente.TipoDeConta,
                Saldo = cliente.Saldo,
                Pessoa = cliente.Pessoa,
            });
        }

        

    }
}
