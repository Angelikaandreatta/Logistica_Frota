using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Entrega
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Veiculo_Id { get; set; }
        public int Endereco_Id { get; set; }
        public string Status { get; set; }
        public DateTime Estimativa_Entrega { get; set; }
        public DateTime? Data_Entrega { get; set; }

        [ForeignKey("Usuario_Id")]
        public virtual Usuarios Usuario { get; set; }

        [ForeignKey("Veiculo_Id")]
        public virtual Veiculos Veiculo { get; set; }

        [ForeignKey("Endereco_Id")]
        public virtual Endereco_Entrega Endereco_Entrega { get; set; }
    }
}
