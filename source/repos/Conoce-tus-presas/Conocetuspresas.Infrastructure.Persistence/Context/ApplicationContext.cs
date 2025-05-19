using Conocetuspresas.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    public DbSet<Presa> Presas { get; set; }
    public DbSet<FotosPresa> FotosPresas { get; set; }
    public DbSet<Proyecto> Proyectos { get; set; }
    public DbSet<FotosProyecto> FotosProyectos { get; set; }
    public DbSet<Contacto> Contactos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FotosPresa>()
            .HasOne(fp => fp.Presa)
            .WithMany(p => p.Fotos)
            .HasForeignKey(fp => fp.PresaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<FotosProyecto>()
            .HasOne(fp => fp.Proyecto)
            .WithMany(p => p.Fotos)
            .HasForeignKey(fp => fp.ProyectoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}