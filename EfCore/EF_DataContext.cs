using Microsoft.EntityFrameworkCore;

namespace SpaceWebApi.EfCore
{
    public class EF_DataContext: DbContext 
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options): base(options) { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
    }
}
