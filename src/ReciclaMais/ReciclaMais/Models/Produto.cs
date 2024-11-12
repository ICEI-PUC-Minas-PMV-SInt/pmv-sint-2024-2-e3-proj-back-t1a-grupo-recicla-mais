using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio adicionar o nome.")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio adicionar uma descrição.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio adicionar a pontuação correspondente ao produto.")]
        [Display(Name = "Pontuação")]
        public int PontuacaoUnitaria { get; set; }
    }
}
