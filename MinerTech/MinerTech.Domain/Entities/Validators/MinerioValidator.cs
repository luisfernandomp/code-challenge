using FluentValidation;
using MinerTech.Domain;

namespace MinerTech.Domain.Validators
{
    public class MinerioValidator : AbstractValidator<Minerio>
    {
        public MinerioValidator()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty()
                .NotNull()
                .WithMessage("Código inválido!");

            RuleFor(c => c.Caracteristica)
                .NotEmpty()
                .NotNull()
                .WithMessage("Característica inválida!");
        }
    }
}
