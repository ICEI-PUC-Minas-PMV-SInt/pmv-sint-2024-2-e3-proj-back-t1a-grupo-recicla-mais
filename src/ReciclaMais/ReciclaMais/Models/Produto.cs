using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório adicionar o nome.")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório adicionar uma descrição.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório adicionar a pontuação correspondente ao produto.")]
        [Display(Name = "Pontuação")]
        public int PontuacaoUnitaria { get; set; }
    }
}
