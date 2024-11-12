using ReciclaMais.Enuns;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("ItensColeta")]
    public class ItemColeta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o produto.")]
        public Produto Produto { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a quantidade.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o estado de conservação.")]
        public EstadosConservacao EstadoConservacao { get; set; }

        public int CalcularPontuacao()
        {
            return Quantidade * Produto.PontuacaoUnitaria;
        }
    }
}
