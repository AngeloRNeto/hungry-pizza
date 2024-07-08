using HungryPizza.Domain.Entities;
using HungryPizza.Domain.Interfaces.Repositories;

namespace HungryPizza.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly HungryContext _context;
        public EnderecoRepository(HungryContext context)
        {
            _context = context;
        }
        public async Task<int> SalvarEnderecoAsync(Endereco novoEndereco)
        {
            _context.Enderecos.Add(novoEndereco);
            return await _context.SaveChangesAsync();
        }
    }
}
