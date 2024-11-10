using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Entrega
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int Usuario_Id { get; set; }
        [JsonIgnore]
        public int Veiculo_Id { get; set; }
        [JsonIgnore]
        public int Endereco_Id { get; set; }
        public string Status { get; set; }
        public DateTime Estimativa_Entrega { get; set; }
        public DateTime? Data_Entrega { get; set; }
        public Usuarios Usuario { get; set; }
        public Veiculos Veiculo { get; set; }
        public Endereco_Entrega Endereco_Entrega { get; set; }
    }
}
