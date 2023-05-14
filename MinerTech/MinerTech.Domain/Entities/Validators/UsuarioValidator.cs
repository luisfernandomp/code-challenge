using FluentValidation;

namespace MinerTech.Domain.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator() 
        {
            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Informe um E-mail válido")
                .NotEmpty()
                .NotNull()
                .WithMessage("E-mail obrigatório");

            RuleFor(u => u.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome obrigatório");

            RuleFor(u => u.Nome.Length)
              .GreaterThan(3)
               .WithMessage("Nome precisa ter no mínimo 3 caracteres");

        }
    }
}
