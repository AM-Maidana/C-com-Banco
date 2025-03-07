using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicios_07MAR
{
    [Table("software")]
    public class Softwares
    {
        [Key]
        [Column("idsoft")]
        public int idsoft { get; set; }

        [Column("produto")]
        public string produto { get; set; }

        [Column("harddisk")]
        public int harddisk { get; set; }

        [Column("memoria_ram")]
        public int memoria_ram { get; set; }

        // Chave estrangeira
        [Column("fk_maquina")]
        public int maquinaId { get; set; }

        [ForeignKey("MaquinaId")]  
        public virtual Maquinas Maquina { get; set; }
    }
}
