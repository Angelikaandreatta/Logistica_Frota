using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Veiculos
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public decimal Capacidade { get; set; }
        public string Status { get; set; }
    }
}
