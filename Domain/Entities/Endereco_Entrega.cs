﻿using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Endereco_Entrega
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
