using System.ComponentModel.DataAnnotations;

namespace ReciclaMais.Models
{
    public class Municipe : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o CPF.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
        public string Cpf { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o sobrenome.")]
        public string Sobrenome { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        public int Pontuacao { get; set; }

        public List<Agendamento> ListarAgendamentos() => new List<Agendamento>();
    }
}
