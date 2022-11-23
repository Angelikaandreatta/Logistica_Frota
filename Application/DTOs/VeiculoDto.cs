using Domain.Enuns;

namespace Application.DTOs
{
    public class VeiculoDto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tamanho { get; set; }
        public Finalidade Finalidade { get; set; }
        public Combustivel Combustivel { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }

        public VeiculoDto()
        { }
    }
}
