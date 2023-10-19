using System;
using Microsoft.EntityFrameworkCore;

namespace sism.Models
{
    public partial class ParshallContext : DbContext
    {
        public ParshallContext()
        {
        }

        public ParshallContext(DbContextOptions<ParshallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dqo> Dqos { get; set; }
        public virtual DbSet<Flujo> Flujos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Dqo>(entity =>
            {
                entity.HasKey(e => e.Hora).HasName("PRIMARY");
                entity.ToTable("dqo", tb => tb.HasComment("mg/l"));
                entity.Property(e => e.Valor).HasColumnName("valor");
                entity.HasIndex(e => e.Hora);
            });

            modelBuilder.Entity<Flujo>(entity =>
            {
                entity.HasKey(e => e.Hora).HasName("PRIMARY");
                entity.ToTable("flujo", tb => tb.HasComment("CuFt/s"));
                entity.Property(e => e.Valor).HasColumnName("valor");
                entity.HasIndex(e => e.Hora);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
