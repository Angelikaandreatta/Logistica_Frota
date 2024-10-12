using FluentValidation;

namespace Application.DTOs.Validations
{
    public class VeiculoDtoValidator : AbstractValidator<VeiculoDto>
    {
        public VeiculoDtoValidator()
        {
            RuleFor(x => x.Marca)
                .NotEmpty()
                .NotNull()
                .WithMessage("Marca deve ser informada.");

            RuleFor(x => x.Modelo)
               .NotEmpty()
               .NotNull()
               .WithMessage("Modelo deve ser informado.");

            RuleFor(x => x.TipoVeiculo)
                .NotEmpty()
                .NotNull()
                .WithMessage("Tipo de Veículo deve ser informado.");
        }
    }
}
