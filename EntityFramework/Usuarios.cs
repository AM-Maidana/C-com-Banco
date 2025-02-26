using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace EntityTeste
{


    [Table("usuarios")] // define o nome da tabela
    public class Usuarios 
    {
        [Column("id")] // define explicitamente o nome da coluna
        public int ID { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty; // Valor parão que evita o campo ser nulo

        [Column("email")]
        public string Email { get; set; } = string.Empty; 
    }
}