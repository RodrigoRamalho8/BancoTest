namespace BancoTest.Servicos.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public int Agencia { get; set; }
        public string TipoDeConta { get; set; }
        public double Saldo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }   
}
