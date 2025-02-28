using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Exercicios_28FEV
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        [Column("idusuario")]
        public int idusuario{ get; set; }

        [Column("senha")]
        public string senha;

        [Column("nomeuser")]
        public string nomeuser {get; set;}

        [Column("ramal")]
        public int ramal {get; set;}

        [Column("especialidade")]
        public string especialidade {get; set;}


    }
}