using FluentValidation;

namespace MinerTech.Domain.Validators
{
    public class RetornoValidator : AbstractValidator<Retorno>
    {
        public RetornoValidator() 
        {
            When(r => r.DataRetorno != null, () =>
            {
                RuleFor(r => r.RetornosCargueiro.Select(x => x.Cargueiro.Minerio).Count())
                .GreaterThan(0)
                .WithMessage("É necessário informar os minérios obtidos com a operação");
            });

            RuleFor(r => r.DataSaida).NotNull().WithMessage("Informe a data de saída");

            RuleFor(r => r.RetornosCargueiro.Select(x => x.Cargueiro).Count())
                .GreaterThan(0)
                .WithMessage("Informe um cargueiro");
        }
    }
}
