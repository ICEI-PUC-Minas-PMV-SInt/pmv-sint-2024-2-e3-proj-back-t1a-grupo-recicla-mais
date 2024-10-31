using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMaisDemo.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o horário.")]
        [Display(Name = "Horário")]
        public TimeOnly Horario { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public Usuario Usuario { get; set; }

    }
}
