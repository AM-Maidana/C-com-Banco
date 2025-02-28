using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicios_28FEV
{
    [Table("maquina")]
    public class Maquina
    {
        [Key]
        [Column("id_maquina")]
        public int id_maquina { get; set; }

        [Column("tipo")]
        public string tipo { get; set; }

        [Column("velocidade")]
        public int velocidade { get; set; }

        [Column("harddisk")]
        public int harddisk { get; set; }

        [Column("placa_rede")]
        public int placa_rede { get; set; }

        [Column("memoria_ram")]
        public int memoria_ram { get; set; }

        // Chave estrangeira
        [Column("fk_usuario")]
        public int idusuario { get; set; }

        // Propriedade de navegação (relacionamento com Usuario)
        [ForeignKey("idusuario")]
        public virtual Usuarios Usuario { get; set; }  
    }
}
