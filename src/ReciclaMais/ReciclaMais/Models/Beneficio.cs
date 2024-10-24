using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Beneficios")]
    public class Beneficio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o titulo do benefício.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a descrição do benefício.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a pontuação do benefício.")]
        [Display(Name = "Pontuação de Troca")]
        public int PontuacaoTroca { get; set; }
    }
}
