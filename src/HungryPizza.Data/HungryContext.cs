using HungryPizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HungryPizza.Data
{
    public class HungryContext : DbContext
    {
        public HungryContext(DbContextOptions<HungryContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<OpcaoPizza> OpcaoPizzas { get; set; }
        public DbSet<PedidoOpcaoPizza> PedidoOpcaoPizzas { get; set; }
    }
}
