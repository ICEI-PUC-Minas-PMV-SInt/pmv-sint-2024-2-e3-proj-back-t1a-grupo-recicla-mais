using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Login { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Senha { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Rua{ get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Numero { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Bairro { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Cidade { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Estado { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obrigatório.")]
        public int Cep { get; set; }
        public string? Complemento { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateOnly? DataNasc { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? DataCriac { get; set; }
        public string? RazaoSocial { get; set; } = string.Empty;
        public string? NomeCompleto { get; set; } = string.Empty;
        public int? CodAgente { get; set; }
        public int? Matricula { get; set; }
        public string? TipoUsuario { get; set; } = string.Empty;
    }
}
