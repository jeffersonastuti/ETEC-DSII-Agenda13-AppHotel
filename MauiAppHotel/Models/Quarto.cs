using System.Globalization;

namespace MauiAppHotel.Models;

public class Quarto
{
    public string Nome { get; init; } = string.Empty;
    public string Descricao { get; init; } = string.Empty;
    public int CapacidadeMaxima { get; init; }
    public decimal ValorDiaria { get; init; }
    public string NomeComPreco => $"{Nome} • {ValorDiaria.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}/noite";
}
