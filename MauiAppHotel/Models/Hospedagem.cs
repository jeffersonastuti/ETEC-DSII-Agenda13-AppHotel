using System.Globalization;

namespace MauiAppHotel.Models;

public class Hospedagem
{
    public int Adultos { get; init; }
    public int Criancas { get; init; }
    public required Quarto QuartoSelecionado { get; init; }
    public DateTime CheckIn { get; init; }
    public DateTime CheckOut { get; init; }

    public int QuantidadeNoites => (CheckOut.Date - CheckIn.Date).Days;
    public decimal ValorTotal => QuartoSelecionado.ValorDiaria * QuantidadeNoites;
    public string ValorTotalFormatado => ValorTotal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
    public string ValorDiariaFormatado => QuartoSelecionado.ValorDiaria.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
    public string PeriodoFormatado => $"{CheckIn:dd/MM/yyyy} a {CheckOut:dd/MM/yyyy}";
    public string HospedesFormatados => $"{Adultos} adulto(s) e {Criancas} criança(s)";
    public string NoitesFormatadas => $"{QuantidadeNoites} noite(s)";
}
