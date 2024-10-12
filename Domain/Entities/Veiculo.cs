using Domain.Enuns;
using Domain.Validators;

namespace Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Capacidade { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }


        public Veiculo()
        { }

        public Veiculo(string placa, string modelo, int capacidade, TipoVeiculo tipoVeiculo)
        {
            Validation(placa, modelo, capacidade, tipoVeiculo);
        }

        public Veiculo(int id, string placa, string modelo, int capacidade, TipoVeiculo tipoVeiculo)
        {
            ValidationException.When(id < 0, "Id deve ser maior que 0.");
            Id = id;
            Validation(placa, modelo, capacidade, tipoVeiculo);
        }

        private void Validation(string placa, string modelo, int capacidade, TipoVeiculo tipoVeiculo)
        {
            ValidationException.When(string.IsNullOrEmpty(placa), "Placa deve ser informada.");
            ValidationException.When(string.IsNullOrEmpty(modelo), "Modelo deve ser informado.");
            ValidationException.When(capacidade <= 0, "Capacidade deve ser informada.");
            ValidationException.When(tipoVeiculo <= 0, "Tipo do Veículo deve ser informado.");

            Placa = placa;
            Modelo = modelo;
            Capacidade = capacidade;
            TipoVeiculo = tipoVeiculo;
        }
    }
}
