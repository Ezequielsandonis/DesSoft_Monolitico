using System;
using System.Collections.Generic;
using DesSoft_Monolitico.Models;
using Microsoft.EntityFrameworkCore;

namespace DesSoft_Monolitico.Data;

public partial class GestionTareaContext : DbContext
{
    public GestionTareaContext()
    {
    }

    public GestionTareaContext(DbContextOptions<GestionTareaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarea> Tareas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarea>(entity =>
        {
            entity.HasKey(e => e.TareaId).HasName("PK__Tareas__5CD83991B9E935FC");

            entity.Property(e => e.FechaLimite).HasColumnType("datetime");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
