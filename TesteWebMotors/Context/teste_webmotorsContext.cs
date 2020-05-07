using Microsoft.EntityFrameworkCore;
using TesteWebMotors.Entidades;

namespace TesteWebMotors.Context
{
    public partial class teste_webmotorsContext : DbContext
    {

        public virtual DbSet<TbAnuncioWebmotors> TbAnuncioWebmotors { get; set; }

        public teste_webmotorsContext(DbContextOptions<teste_webmotorsContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=teste_webmotors;Trusted_Connection=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAnuncioWebmotors>(entity =>
            {
                entity.ToTable("tb_AnuncioWebmotors");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .IsRequired()
                    .HasColumnName("observacao")
                    .HasColumnType("text");

                entity.Property(e => e.Quilometragem).HasColumnName("quilometragem");

                entity.Property(e => e.Versao)
                    .IsRequired()
                    .HasColumnName("versao")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
