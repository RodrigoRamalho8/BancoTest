using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest.Servicos
{
    public class RealizaTransferencia
    {
        public RealizaTransferencia() { }
        public void RealizarTransferencia(Cliente cliente1, Cliente cliente2, double valor) 
        {
            cliente1.Sacar(valor);
            cliente2.Depositar(valor);
        }
    }
}
