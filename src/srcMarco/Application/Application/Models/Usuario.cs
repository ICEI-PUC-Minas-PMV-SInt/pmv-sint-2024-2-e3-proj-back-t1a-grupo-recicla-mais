namespace Application.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Telefone { get; set; }
        public string Rua{ get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public int Cep { get; set; }
        public string Complemento { get; set; } = string.Empty;
        public string? RazaoSocial { get; set; } = string.Empty;
        public string? NomeCompleto { get; set; } = string.Empty;
        public int? CodAgente { get; set; }
        public int? Matricula { get; set; }
        public string TipoUsuario { get; set; } = string.Empty;
    }
}
