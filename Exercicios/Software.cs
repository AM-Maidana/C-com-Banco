using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicios_28FEV
{
    [Table("software")]
    public class Software
    {
        [Key]
        [Column("id_software")]
        public int Id { get; set; }

        [Column("produto")]
        public string Produto { get; set; }

        [Column("harddisk")]
        public int HD { get; set; }

        [Column("memoria_ram")]
        public int MemoriaRAM { get; set; }

        // Chave estrangeira
        [Column("fk_maquina")]
        public int MaquinaId { get; set; }

        [ForeignKey("MaquinaId")]  
        public virtual Maquina Maquina { get; set; }
    }
}
