using ReciclaMais.Enuns;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o sobrenome.")]
        public string Sobrenome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CPF.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; } = null!;

        [Display(Name = "Pontuação")]
        public int Pontuacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a razão social.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o nome fantasia.")]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o CNPJ.")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a matrícula.")]
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o telefone.")]
        public string Telefone { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o e-mail.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o username.")]
        [Display(Name = "Razão Social")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a senha.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

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
    }
}
