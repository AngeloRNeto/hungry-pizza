using FluentValidation;
using HungryPizza.Api.Models.OpcaoPizza;

namespace HungryPizza.Api.Validations
{
    public class RegistroOpcaoPizzaModelValidator : AbstractValidator<RegistroOpcaoPizzaModel>
    {
        public RegistroOpcaoPizzaModelValidator()
        {
            RuleFor(x => x.DescricaoSabor).NotEmpty().WithMessage("Informe a descrição do novo sabor");
            RuleFor(x => x.Valor).NotEmpty().WithMessage("Informe o valor");
        }
    }
}
