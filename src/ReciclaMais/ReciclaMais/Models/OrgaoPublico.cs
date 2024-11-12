using System.ComponentModel.DataAnnotations;

namespace ReciclaMais.Models
{
    public class OrgaoPublico : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string NomeOrg { get; set; } = null!;

        public List<Agendamento> ConsultarAgendamentos() => new List<Agendamento>();
    }
}
