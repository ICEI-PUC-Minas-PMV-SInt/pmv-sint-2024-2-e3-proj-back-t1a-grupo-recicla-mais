namespace ReciclaMais.Enuns
{
    public class EstadosConservacaoHelper
    {
        public static readonly Dictionary<EstadosConservacao, double> Percentuais = new Dictionary<EstadosConservacao, double>
    {
        { ReciclaMais.Enuns.EstadosConservacao.Novo, 1.0 },
        { ReciclaMais.Enuns.EstadosConservacao.Usado, 0.5 },
        { ReciclaMais.Enuns.EstadosConservacao.Descarte, 0.1 }
    };
    }
}
