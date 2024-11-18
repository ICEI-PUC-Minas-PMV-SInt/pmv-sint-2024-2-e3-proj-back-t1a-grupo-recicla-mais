using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaMais.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        [Display(Name = "Data")]
        public DateTime DataAgendamento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o horário.")]
        [Display(Name = "Horário")]
        public string Horario { get; set; }

        [Display(Name = "Pontuação Total")]
        public int PontuacaoTotal { get; set; }

        public List<ItemColeta> ItensColeta { get; set; }

        public int CalcularPontuacaoTotal()
        {
            // Implementação do cálculo da pontuação total
            return ItensColeta.Sum(item => item.CalcularPontuacao());
        }
    }
}
