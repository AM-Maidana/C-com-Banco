using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace EntityTeste
{
    public class Conexao : DbContext // Herda a classe principal do entity framework
    {
        public DbSet<Usuarios> Usuarios { get; set; } // -> Definindo a tabela que vamos usar // DbSet - coleção de objetos que eu vou usar
                                                      // Trata-se como se fosse uma tabela, mas é uma coleção ou lista de objetos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // ´r uma classe que perite confgura o DbContexte para conectar com o banco
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Conexao;Username=postgres;Password=1234");

        }
        // metodo para configurar o mapeamento de entidades no banco de dados -- nao é obrigatório
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("usuarios"); // - mapeia a tabela usuario
        } // Garante que a tabela usuarios vai ser usada para a tabela usuarios no banco de dados
        
    }
}