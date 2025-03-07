using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Exercicios_07MAR
{
    public class Conexao_Banco : DbContext
    {
        public DbSet<Usuarios> usuarios {get; set;}
        public DbSet<Maquinas> maquinas {get; set;}
        public DbSet<Softwares> softwares {get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Conexao;Username=postgres;Password=1234");

        }
    }
}