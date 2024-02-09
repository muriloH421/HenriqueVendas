using Microsoft.EntityFrameworkCore;
using AppVendas.Models;

namespace AppVendas.Data
{
    public class AppVendasContext : DbContext
    {
        public AppVendasContext(DbContextOptions<AppVendasContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Produto>().ToTable("Produto");
        }
        public DbSet<AppVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<AppVendas.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<AppVendas.Models.Produto> Produto { get; set; } = default!;
    }
}
