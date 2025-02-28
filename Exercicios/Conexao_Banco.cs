using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore; 

namespace Exercicios_28FEV
{
    public class Conexao_Banco : DbContext
    {
        public DbSet<Usuarios> usuarios {get; set;}
        public DbSet<Maquina> maquinas {get; set;}
        public DbSet<Software> softwares {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Conexao;Username=postgres;Password=1234");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("usuarios");
            modelBuilder.Entity<Maquina>().ToTable("maquina");
            modelBuilder.Entity<Software>().ToTable("software");
        }

    }
}