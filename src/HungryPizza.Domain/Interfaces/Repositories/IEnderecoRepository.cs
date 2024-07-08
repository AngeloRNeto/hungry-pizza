using HungryPizza.Domain.Entities;

namespace HungryPizza.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository
    {
        Task<int> SalvarEnderecoAsync(Endereco novoEndereco);
    }
}
