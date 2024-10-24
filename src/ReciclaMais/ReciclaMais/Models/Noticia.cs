using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Noticias")]
    public class Noticia
    {
        [Key]
        public int Id { get; set; }

        public string Imagem { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio informar o título.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio adicionar um resumo.")]
        public string Resumo { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio adicionar um conteúdo.")]
        [Display(Name = "Texto Conteúdo")]
        public string TextoConteudo { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatorio adicionar a data de publicação.")]
        [Display(Name = "Data de Publicação")]
        public DateTime DataPublicacao { get; set; }
    }
}
