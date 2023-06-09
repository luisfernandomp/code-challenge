using FluentValidation;
using MinerTech.Domain.Entities.Classes;

namespace MinerTech.Domain.Validators
{
    public class ClasseValidator : AbstractValidator<Classe>
    {
        public ClasseValidator()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty()
                .NotNull()
                .WithMessage("Descrição inválida!");
        }
    }
}
