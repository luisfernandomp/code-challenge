using FluentValidation;
using MinerTech.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
