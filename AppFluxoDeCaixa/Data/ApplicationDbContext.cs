using AppFluxoDeCaixa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AppFluxoDeCaixa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Clientes> Fornecedor { get; set; }
        public DbSet<Clientes> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Clientes>().ToTable("4950Clientes");
            builder.Entity<Fornecedor>().ToTable("Fornecedor");

        }
        public DbSet<AppFluxoDeCaixa.Models.Fornecedor> Fornecedor_1 { get; set; } = default!;
    }
}