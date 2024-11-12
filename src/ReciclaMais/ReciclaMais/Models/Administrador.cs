using System.ComponentModel.DataAnnotations;

namespace ReciclaMais.Models
{
    public class Administrador : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o apelido de administrador.")]
        public string NomeAdm { get; set; } = null!;

        public void CadastrarNoticia(string img, string titulo, string resumo, string conteudo, DateTime dataPublicacao)
        {
            // Implementação do cadastro de notícia
        }

        public void CadastrarProduto(string nome, string descricao, int pontuacaoUnit)
        {
            // Implementação do cadastro de produto
        }

        public void ExcluirNoticia(Noticia noticia)
        {
            // Implementação da exclusão de notícia
        }
    }
}
