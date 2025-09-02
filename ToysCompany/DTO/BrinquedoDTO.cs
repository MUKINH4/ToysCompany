using System.ComponentModel.DataAnnotations;

namespace ToysCompany.DTO
{
    public class BrinquedoDTO
    {
        [Required(ErrorMessage = "o campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo tipo é obrigatório")]
        public string Tipo { get; set; }

        [Range(14, 100, ErrorMessage = "A classificação mínima é {1} e a máxima é {2}")]
        public int Classificacao { get; set; }
        [Required(ErrorMessage = "O campo tamanho é obrigatório")]
        [Range(1, double.MaxValue)]
        public double Tamanho { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O número não pode ser negativo e tem que ser maior que zero")]
        public double Preco { get; set; }
    }
}
