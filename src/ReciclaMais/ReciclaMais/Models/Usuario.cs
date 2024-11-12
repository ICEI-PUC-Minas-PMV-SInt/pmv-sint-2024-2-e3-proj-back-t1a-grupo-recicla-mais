using ReciclaMais.Enuns;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Usuarios")]
    public abstract class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o estado.")]
        public EstadosBrasil Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o cidade.")]
        public string Cidade { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o bairro.")]
        public string Bairro { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a rua.")]
        public string Rua { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o número da residência.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        public string Complemento { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o CEP.")]
        [Display(Name = "CEP")]
        public string Cep { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o telefone.")]
        public string Telefone { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o e-mail.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o username.")]
        [Display(Name = "Usuário")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o tipo de usuário.")]
        public TiposUsuario Tipo { get; set; }


        public virtual bool VerificarLogin() => true;
        public virtual void Cadastro() { }
        public virtual void AtualizarPerfil() { }

    }
}
