using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAgendamentos.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a pontuação.")]
        [Display(Name = "Pontuação")]
        public int Pontuacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o estado.")]
        public Estado Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cidade.")]
        public string Cidade { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o bairro.")]
        public string Bairro { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar a rua.")]
        public string Rua { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o número da residência.")]
        [Display(Name = "N° Residência")]
        public int NumeroCasa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o cep.")]
        [Display(Name = "CEP")]
        public string Cep { get; set; } = null!;
    }
}

public enum Estado
{
    AC = 1,  // Acre
    AL = 2,  // Alagoas
    AP = 3,  // Amapá
    AM = 4,  // Amazonas
    BA = 5,  // Bahia
    CE = 6,  // Ceará
    DF = 7,  // Distrito Federal
    ES = 8,  // Espírito Santo
    GO = 9,  // Goiás
    MA = 10, // Maranhão
    MT = 11, // Mato Grosso
    MS = 12, // Mato Grosso do Sul
    MG = 13, // Minas Gerais
    PA = 14, // Pará
    PB = 15, // Paraíba
    PR = 16, // Paraná
    PE = 17, // Pernambuco
    PI = 18, // Piauí
    RJ = 19, // Rio de Janeiro
    RN = 20, // Rio Grande do Norte
    RS = 21, // Rio Grande do Sul
    RO = 22, // Rondônia
    RR = 23, // Roraima
    SC = 24, // Santa Catarina
    SP = 25, // São Paulo
    SE = 26, // Sergipe
    TO = 27  // Tocantins
}
