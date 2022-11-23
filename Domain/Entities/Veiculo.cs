using Domain.Enuns;
using Domain.Validators;

namespace Domain.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tamanho { get; set; }
        public Finalidade Finalidade { get; set; }
        public Combustivel Combustivel { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }

        public Veiculo()
        { }

        public Veiculo(string marca, string modelo, string tamanho, Finalidade finalidade, Combustivel combustível, TipoVeiculo tipoVeiculo)
        {
            Validation(marca, modelo, tamanho, finalidade, combustível, tipoVeiculo);
        }

        public Veiculo(int id, string marca, string modelo, string tamanho, Finalidade finalidade, Combustivel combustível, TipoVeiculo tipoVeiculo)
        {
            ValidationException.When(id < 0, "Id deve ser maior que 0.");
            Id = id;
            Validation(marca, modelo, tamanho, finalidade, combustível, tipoVeiculo);
        }

        private void Validation(string marca, string modelo, string tamanho, Finalidade finalidade, Combustivel combustível, TipoVeiculo tipoVeiculo)
        {
            ValidationException.When(string.IsNullOrEmpty(marca), "Marca deve ser informada.");
            ValidationException.When(string.IsNullOrEmpty(modelo), "Modelo deve ser informado.");
            ValidationException.When(string.IsNullOrEmpty(tamanho), "Tamanho deve ser informado.");
            ValidationException.When(finalidade <= 0, "Finalidade deve ser informada.");
            ValidationException.When(combustível <= 0, "Combustível deve ser informado.");
            ValidationException.When(tipoVeiculo <= 0, "Tipo do Veículo deve ser informado.");

            Marca = marca;
            Modelo = modelo;
            Tamanho = tamanho;
            Finalidade = finalidade;
            Combustivel = combustível;
            TipoVeiculo = tipoVeiculo;
        }
    }
}
