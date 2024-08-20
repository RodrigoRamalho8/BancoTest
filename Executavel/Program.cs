using BancoTest;
using BancoTest.Servicos;


public class Program()
{
     public static void Main(string[] args)
    {
        //Servicos
        var servicoDeCadastrarPessoa = new CadastraPessoa();
        var servicoDeCadastrarCliente = new CadastraCliente();
        var servicoDeTransferencia = new RealizaTransferencia();



        //Pessoas
        var pessoa1 = servicoDeCadastrarPessoa.CadastrarPessoa("Rodrigo", "Garcia Ramalho", "07713297170", "rodrigogarcia.ramalho@gmail.com", "M");
        var pessoa2 = servicoDeCadastrarPessoa.CadastrarPessoa("Henrique", "Callejas Oliveira Lima", "04483515101", "henriquecallejasol@gmail.com", "Intersex");
        //Tipos de pessoas
        var cliente1 = servicoDeCadastrarCliente.CadastrarCliente(08, "Poupança", pessoa1);
        var cliente2 = servicoDeCadastrarCliente.CadastrarCliente(25, "Corrente", pessoa2);
        //var funcionario1 = new Funcionario("Horista", 1500.50, pessoa2, TipoDeFuncionario.Funcionario);


        Console.WriteLine(cliente1.Pessoa.PrimeiroNome + " " + cliente1.Pessoa.Sobrenome);
        Console.WriteLine(cliente1.Saldo);
        Console.WriteLine(cliente2.Saldo);
        cliente1.Sacar(15.00);
        servicoDeTransferencia.RealizarTransferencia(cliente1, cliente2, 150.00);
        
        cliente1.Depositar(1000);
        servicoDeTransferencia.RealizarTransferencia(cliente1, cliente2, 150.00);
        Console.WriteLine(cliente1.Saldo);
        Console.WriteLine(cliente2.Saldo);
        cliente1.Sacar(150.00);
        
        //Console.WriteLine(funcionario1.Salario);
        //funcionario1.AlterarOSalario(2500.50);
        //Console.WriteLine(funcionario1.Salario);






    }
}