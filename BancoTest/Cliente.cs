using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest
{
    public class Cliente
    {
        public int Id {  get; private set; }
        public int Agencia { get; private set; }
        public string TipoDeConta { get; private set; }
        public double Saldo { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
        protected Cliente() { }
        public Cliente(int agencia, string tipoConta, Pessoa pessoa) 
        {
            ValidarDadosObrigatorios(agencia, tipoConta, pessoa);
            Agencia = agencia;
            TipoDeConta = tipoConta;
            Saldo = 0;
            Pessoa = pessoa;
        }

        public void Depositar(double valor)
        {
            ValidarSeOValorEhNuloOuMenorQueZero(valor);
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            ValidarSeOValorEhNuloOuMenorQueZero(valor);
            ValidarSaque(valor);           
            Saldo -= valor;            
            
        }
        public void AlterarAgencia(int novaAgencia)
        {
            ValidarAgencia(novaAgencia);
            Agencia = novaAgencia;
        }
        public void AlterarTipoDeConta(string novoTipoDeConta)
        {
            TipoDeConta = novoTipoDeConta;
        }
        private void ValidarSeOValorEhNuloOuMenorQueZero(double valorASerValidado)
        {
            if (valorASerValidado <= 0)
            {
                throw new Exception("O valor não pode ser menor ou igual a zero!");
            }
        }
        private void ValidarSaque(double valorASerValidado)
        {
            if (valorASerValidado > Saldo)
            {
                throw new Exception("O valor de saque não pode ser maior que o saldo!");                
            }
        }
        private void ValidarAgencia(int agenciaASerValidada)
        {
            if (agenciaASerValidada <= 0)
            {
                throw new Exception("O número da agência não pode ser menor ou igual a zero!");
            }
        }
        private void ValidarTipoDeConta(string tipoDeContaASerValidado)
        {
            if (string.IsNullOrEmpty(tipoDeContaASerValidado))
            {
                throw new Exception("O tipo de conta precisa ser preenchido.");
            }
        }
        private void ValidarPessoa(Pessoa pessoaASerValidada)
        {
            if(pessoaASerValidada == null)
            {
                throw new Exception("Pessoa inválida.");
            }
        }

        public void ValidarDadosObrigatorios(int agenciaASerValidada, string tipoDeContaASerValidado, Pessoa pessoaASerValidada)
        {
            ValidarAgencia(agenciaASerValidada);
            ValidarTipoDeConta(tipoDeContaASerValidado);
            ValidarPessoa(pessoaASerValidada);
        }
              
        
    }
}
