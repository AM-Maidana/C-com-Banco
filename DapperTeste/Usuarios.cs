using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DapperTeste
{
    //Atributo de mapeamento C# para mapear os campos das tabelas
    [Table("Usuarios")]
    public class Usuarios
    {
        //[key] //Atributo para indicar a chave primária
        // Se for usar chave estrangeira, usar [ForeignKey("nome_da_coluna")]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty; // Inicializando a variavel com string vazia

        [Column("email")]
        public string Email { get; set; } = string.Empty;
        

    }
}