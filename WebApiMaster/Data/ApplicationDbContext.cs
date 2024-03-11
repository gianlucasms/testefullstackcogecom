using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cooperado>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<UnidadeConsumidora>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<UnidadeConsumidora>()
                .Property(u => u.Codigo)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<UnidadeConsumidora>()
                .Property(u => u.Concessionaria)
                .IsRequired();

            modelBuilder.Entity<UnidadeConsumidora>()
                .HasOne(u => u.Cooperado)
                .WithMany()
                .HasForeignKey(u => u.CooperadoId)
                .IsRequired();

            modelBuilder.Entity<UnidadeConsumidora>()
                .HasOne(u => u.Endereco)
                .WithMany()
                .HasForeignKey(u => u.EnderecoId)
                .IsRequired();

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Logradouro)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Bairro)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Localidade)
                .HasMaxLength(255);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Uf)
                .HasMaxLength(2)
                .IsRequired();

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .HasMaxLength(10);


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Cooperado> Cooperados { get; set; }
        public DbSet<UnidadeConsumidora> UnidadesConsumidoras { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
