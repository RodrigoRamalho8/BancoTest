using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest
{
    public class Funcionario
    {
        public int Id {  get; private set; }
        public string TipoDeContrato { get; private set; }
        public double Salario { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
        public TipoDeFuncionario Tipo { get; private set; }

        protected Funcionario() { }
        public Funcionario(string tipoContrato, double salario, Pessoa pessoa, TipoDeFuncionario tipo = TipoDeFuncionario.Funcionario)
        {
            ValidarDadosObrigatorios(tipoContrato, salario, pessoa);
            TipoDeContrato = tipoContrato;
            Salario = salario;
            Pessoa = pessoa;
            Tipo = tipo;
        }

        public void AlterarOTipoDeContrato(string novoTipoDeContrato)
        {
            TipoDeContrato = novoTipoDeContrato;
        }
        public void AlterarOSalario(double novoSalario)
        {
            Salario = novoSalario;
        }
        public void AlterarTipoDeFuncionario(TipoDeFuncionario novoTipo)
        {
            Tipo = novoTipo;
        }

        private void ValidarTipoDeContrato(string tipoDeContratoASerValidado)
        {
            if (string.IsNullOrEmpty(tipoDeContratoASerValidado))
            {
                throw new Exception("Tipo de contrato inválido.");
            }
        }
        
        private void ValidarSeOValorEhNuloOuMenorQueZero(double valorASerValidado)
        {
            if (valorASerValidado <= 0.0)
            {
                throw new Exception("O valor não pode ser menor ou igual a zero!");
            }
        }

        private void ValidarOSalario(double salarioASerValidado)
        {
            ValidarSeOValorEhNuloOuMenorQueZero(salarioASerValidado);
        }

        private void ValidarPessoa(Pessoa pessoaASerValidada)
        {
            if (pessoaASerValidada == null)
            {
                throw new Exception("Pessoa inválida.");
            }
        }

        private void ValidarDadosObrigatorios(string tipoDeContratoASerValidado, double salarioASerValidado, Pessoa pessoaASerValidada)
        {
            ValidarTipoDeContrato(tipoDeContratoASerValidado);
            ValidarOSalario(salarioASerValidado);
            ValidarPessoa(pessoaASerValidada);
        }

    }
}
