using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Entrega
    {
        public Guid Id { get; set; }
        public Guid Usuario_Id { get; set; }
        public Guid Veiculo_Id { get; set; }
        public Guid Endereco_Id { get; set; }
        public string Status { get; set; }
        public DateTime Estimativa_Entrega { get; set; }
        public DateTime? Data_Entrega { get; set; }

        [ForeignKey("Usuario_Id")]
        public Usuarios Usuario { get; set; }

        [ForeignKey("Veiculo_Id")]
        public Veiculos Veiculo { get; set; }

        [ForeignKey("Endereco_Id")]
        public Endereco_Entrega Endereco_Entrega { get; set; }
    }
}
