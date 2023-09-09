using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using almacenes.Models;

namespace almacenes.Data;

public partial class almacenesContext : DbContext
{
    public almacenesContext(DbContextOptions<almacenesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("almacenes");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnName("codigo");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .HasColumnName("lugar");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.NumReferencia).HasName("PRIMARY");

            entity.ToTable("cajas");

            entity.HasIndex(e => e.Almacen, "almacen");

            entity.Property(e => e.NumReferencia)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("numReferencia");
            entity.Property(e => e.Almacen).HasColumnName("almacen");
            entity.Property(e => e.Contenido)
                .HasMaxLength(100)
                .HasColumnName("contenido");
            entity.Property(e => e.Valor).HasColumnName("valor");

            entity.HasOne(d => d.AlmacenNavigation).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.Almacen)
                .HasConstraintName("cajas_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
