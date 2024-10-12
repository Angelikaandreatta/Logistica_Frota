using Domain.Validators;

namespace Domain.Entities
{
    public class Entrega
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public string Endereço { get; set; }
        public int Numero_Endereco { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Peso { get; set; }
        public DateTime Data_Entrega { get; set; }


        public Entrega()
        { }

        public Entrega(int veiculoId, string endereco, int numero_endereco, string cep, string cidade, string estado, int peso, DateTime dataEntrega)
        {
            Validation(veiculoId, endereco, numero_endereco, cep, cidade, estado, peso, dataEntrega);
        }

        public Entrega(int id, int veiculoId, string endereco, int numero_endereco, string cep, string cidade, string estado, int peso, DateTime dataEntrega)
        {
            ValidationException.When(id < 0, "Id deve ser maior que 0.");
            Id = id;
            Validation(veiculoId, endereco, numero_endereco, cep, cidade, estado, peso, dataEntrega);
        }

        private void Validation(int veiculoId, string endereco, int numero_endereco, string cep, string cidade, string estado, int peso, DateTime dataEntrega)
        {
            ValidationException.When(veiculoId <= 0, "Id do veículo deve ser informado.");
            ValidationException.When(string.IsNullOrEmpty(endereco), "Endereço deve ser informado.");
            ValidationException.When(numero_endereco <= 0, "Número do endereço deve ser informado.");
            ValidationException.When(string.IsNullOrEmpty(cep), "CEP deve ser informado.");
            ValidationException.When(string.IsNullOrEmpty(cidade), "Cidade deve ser informada.");
            ValidationException.When(string.IsNullOrEmpty(estado), "Estado deve ser informado.");
            ValidationException.When(peso <= 0, "Peso deve ser informado.");
            ValidationException.When(dataEntrega == DateTime.MinValue, "Data para Entrega deve ser informada.");

            VeiculoId = veiculoId;
            Endereço = endereco;
            Numero_Endereco = numero_endereco;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Peso = peso;
            Data_Entrega = dataEntrega;
        }
    }
}
