using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BancoTest
{
    public class Pessoa
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome {  get; private set; }
        [Key]
        public string CPF {  get; private set; } 
        public string Email { get; private set; }
        public string Genero { get; private set; }
        public DateTime DataDeCriacao {  get; private set; }
        public Pessoa() { }

        public Pessoa(string primeiroNome, string sobrenome, string cpf, string email, string genero)
        {
            ValidarDadosCadastrais(primeiroNome, sobrenome, cpf, email, genero);
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Email = email;
            Genero = genero;
            DataDeCriacao = DateTime.Now;
        }

        public void AlterarPrimeiroNome(string novoPrimeiroNome)
        {
            ValidarOPrimeiroNome(novoPrimeiroNome);
            PrimeiroNome = novoPrimeiroNome;
        }
        public void AlterarSobrenome(string novoSobrenome)
        {
            ValidarOSobrenome(novoSobrenome);
            Sobrenome = novoSobrenome;
        }
        public void AlterarCPF(string novoCPF)
        {
            ValidarOCPF(novoCPF);
            CPF = novoCPF;
        }
        public void AlterarOEmail(string novoEmail)
        {
            ValidarOEmail(novoEmail);
            Email = novoEmail;
        }
        public void AlterarOGenero(string novoGenero)
        {
            ValidarOGenero(novoGenero);
            Genero = novoGenero;
        }
        private void ValidarOPrimeiroNome(string primeiroNomeASerValidado)
        {
            if (string.IsNullOrEmpty(primeiroNomeASerValidado))
            {
                throw new Exception("É obrigatório preencher o campo nome.");
            }
        }
        private void ValidarOSobrenome(string nomeASerValidado)
        {
            if(string.IsNullOrEmpty(nomeASerValidado))
            {
                throw new Exception("É obrigatório preencher o campo sobrenome");
            }
        }
        private void ValidarOCPF(string cpfASerValidado)
        {
            if(string.IsNullOrEmpty(cpfASerValidado))
            {
                throw new Exception("É obrigatório preencher o campo CPF.");
            }
        }

        private void ValidarOEmail(string emailASerValidado)
        {
            if(string.IsNullOrEmpty(emailASerValidado))
            {
                throw new Exception("É obrigatório preencher o campo Email");
            }
        }
        private void ValidarOGenero(string generoASerValidado)
        {
            if(string.IsNullOrEmpty(generoASerValidado))
            {
                throw new Exception("É obrigatório preencher o campo gênero.");
            }
        }
        private void ValidarDadosCadastrais(string primeiroNomeASerValidado, string nomeASerValidado, string cpfASerValidado,
            string emailASerValidado, string generoASerValidado)
        {
            ValidarOPrimeiroNome(primeiroNomeASerValidado);
            ValidarOSobrenome(nomeASerValidado);
            ValidarOCPF(cpfASerValidado);
            ValidarOEmail(emailASerValidado);
            ValidarOGenero(generoASerValidado);
        }


    }

    
}
