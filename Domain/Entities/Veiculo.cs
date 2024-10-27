namespace Domain.Entities
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public decimal Capacidade { get; set; }
        public string Status { get; set; }
    }
}
