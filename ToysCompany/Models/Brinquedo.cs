using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToysCompany.Models
{
    [Table("TDS_TB_Brinquedos")]
    public class Brinquedo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id_Brinquedo")]
        public int Id { get; set; }
    
        [Required]
        [Column("Nome_brinquedo")]
        public string Nome { get; set; }

        [Required]
        [Column("Tipo_brinquedo")]
        public string Tipo { get; set; }

        [Required]
        [Range(14, 100, ErrorMessage = "A classificação mínima é {1} e a máxima é {2}")]
        public int Classificacao { get; set; }

        [Required]
        public double Tamanho { get; set; }
        [Range(0.01, double.MaxValue)]
        public double Preco { get; set; }
    }
}
