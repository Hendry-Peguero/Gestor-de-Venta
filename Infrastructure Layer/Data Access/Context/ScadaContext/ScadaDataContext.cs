﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ApiPresidenciaDR.Models.Context.ScadaContext;

namespace ApiPresidenciaDR.Models.Context.ScadaContext;

public partial class ScadaDataContext : DbContext
{
    public ScadaDataContext(DbContextOptions<ScadaDataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    //public DbSet<ApiPresidenciaDR.Models.Context.ScadaContext.PotenciaActiva> GetPotenciaActiva4SegundosResult { get; set; } = default!;
}