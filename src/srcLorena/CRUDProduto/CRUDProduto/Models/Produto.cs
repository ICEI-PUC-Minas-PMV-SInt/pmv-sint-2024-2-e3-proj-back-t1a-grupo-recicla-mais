using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDProduto.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Declare o tipo de produto")]
        [Display(Name = "Tipo de produto")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Declare o estado de conservação do produto")]
        [Display(Name = "Estado de conservação")]
        public string Qualidade { get; set; }

        [Required(ErrorMessage = "Declare a pontuação unitária do produto")]
        [Display(Name = "Pontuação do Produto")]
        public int PontuacaoProduto { get; set; }

        
    }
}
