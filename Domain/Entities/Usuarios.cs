using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Usuarios
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Acesso { get; set; }
    }
}
