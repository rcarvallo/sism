using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace sism.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //=> optionsBuilder.UseMySql("server=parshall;port=3306;database=parshall;uid=visor;password=bRn!", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.1.38-mariadb"));

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
        });

        modelBuilder.Entity<Flujo>(entity =>
        {
            entity.HasKey(e => e.Hora).HasName("PRIMARY");

            entity.ToTable("flujo", tb => tb.HasComment("CuFt/s"));

            entity.Property(e => e.Valor).HasColumnName("valor");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
