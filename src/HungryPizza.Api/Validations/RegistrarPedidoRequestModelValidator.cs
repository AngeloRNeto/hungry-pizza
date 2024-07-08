using FluentValidation;
using HungryPizza.Api.Models.Pedido;
using HungryPizza.Api.ViewModels.Pedido;

namespace HungryPizza.Api.Validations
{
    public class RegistrarPedidoRequestModelValidator : AbstractValidator<RegistrarPedidoRequestModel>
    {
        public RegistrarPedidoRequestModelValidator()
        {
            RuleFor(x => x.Endereco).Must(ValidaEndereco).WithMessage("Existem campos no endereço que devem ser preenchidos");
            RuleFor(x => x.Sabores).Must(ValidateQtdSabores).WithMessage("Um pedido deve ter no mínimo uma pizza e no máximo 10");
        }

        private bool ValidateQtdSabores(List<List<int>> sabores)
        {
            var value = sabores.Count() > 10 || sabores.Count() == 0;
            return !value;
        }
        private bool ValidaEndereco(EnderecoPedidoModel endereco)
        {
            var value = string.IsNullOrEmpty(endereco.Rua) || string.IsNullOrEmpty(endereco.Numero) || string.IsNullOrEmpty(endereco.Bairro);
            return !value;
        }
    }
}
