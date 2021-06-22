using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Registro_Detalle2_Ap2.Models;


namespace Registro_Detalle2_Ap2.DAL{

    public class Contexto : DbContext{
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos{ get; set;}
        public DbSet<Suplidores> Suplidores { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source= DATA/Ordenes.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity <Suplidores>().HasData(new Suplidores {SuplidorID=1, Nombres="Ramon"});
        modelBuilder.Entity <Suplidores>().HasData(new Suplidores {SuplidorID=2, Nombres="Pablo"});
        modelBuilder.Entity <Suplidores>().HasData(new Suplidores {SuplidorID=3, Nombres="Cristian"});


        modelBuilder.Entity <Productos>().HasData(new Productos {ProductoId=1, Concepto="Arroz", Costo= 22,  ValorInventario =10});
        modelBuilder.Entity <Productos>().HasData(new Productos {ProductoId=2, Concepto="Azucar", Costo= 50,  ValorInventario =6});
        modelBuilder.Entity <Productos>().HasData(new Productos {ProductoId=3, Concepto="Chocolate", Costo= 25,  ValorInventario =20});

    }

 }   
}