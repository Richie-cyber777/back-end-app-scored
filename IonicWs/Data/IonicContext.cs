using System;
using System.Collections.Generic;
using IonicWs.Models;
using Microsoft.EntityFrameworkCore;

namespace IonicWs.Data;

public partial class IonicContext : DbContext
{
    public IonicContext()
    {
    }

    public IonicContext(DbContextOptions<IonicContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Server=dbitu.cccj6wmrxbgd.af-south-1.rds.amazonaws.com;Database=Ionic; User Id=admin; Password=rootroot;MultipleActiveResultSets=true;Encrypt=False;TrustServerCertificate=False;");
       optionsBuilder.UseLazyLoadingProxies();
    
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);

        modelBuilder.Entity<Equipe>()
            .HasOne(e => e.Competition);

        modelBuilder.Entity<General>()
            .HasOne(g => g.Equipe);

        modelBuilder.Entity<Defense>()
            .HasOne(d => d.Equipe);
        modelBuilder.Entity<Attaque>()
            .HasOne(a => a.Equipe);



    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    public DbSet<IonicWs.Models.Equipe> Equipes { get; set;}
    public DbSet<IonicWs.Models.Competition> Competitions { get; set;}
    public DbSet<IonicWs.Models.General> General { get; set;}
    public DbSet<IonicWs.Models.Defense> Defense { get; set;}
    public DbSet<IonicWs.Models.Attaque> Attaque { get; set;}
}
