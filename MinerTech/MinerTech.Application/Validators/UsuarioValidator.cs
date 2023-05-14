using FluentValidation;
using MinerTech.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Application.Validators
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

            RuleFor(u => u.Senha)
                .NotEmpty()
                .NotNull()
                .WithMessage("Senha obrigatória");


            RuleFor(u => u.Senha.Length)
                .GreaterThan(5)
                .WithMessage("A senha precisa ter no mínimo 5 caracteres");

        }
    }
}
