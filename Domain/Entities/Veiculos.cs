namespace Domain.Entities
{
    public class Veiculos
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public decimal Capacidade { get; set; }
        public string Status { get; set; }
    }
}
