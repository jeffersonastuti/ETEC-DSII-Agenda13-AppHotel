using System.Collections.ObjectModel;
using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ObservableCollection<Quarto> Quartos { get; } = new()
    {
        new Quarto { Nome = "Quarto Essencial", Descricao = "Conforto para duas pessoas", CapacidadeMaxima = 2, ValorDiaria = 189m },
        new Quarto { Nome = "Quarto Família", Descricao = "Espaço para toda a família", CapacidadeMaxima = 4, ValorDiaria = 289m },
        new Quarto { Nome = "Suíte Premium", Descricao = "Mais conforto para sua estadia", CapacidadeMaxima = 5, ValorDiaria = 419m }
    };

    public ContratacaoHospedagem()
    {
        InitializeComponent();
        BindingContext = this;
        pck_quarto.SelectedIndex = 1;
        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.Date = DateTime.Today;
        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.Date = DateTime.Today.AddDays(2);
    }

    private void OnCheckinDateSelected(object sender, DateChangedEventArgs e)
    {
        // No .NET MAUI 10, a data selecionada pode ser nula.
        if (e.NewDate is not DateTime novaData)
            return;

        DateTime checkoutMinimo = novaData.Date.AddDays(1);
        dtpck_checkout.MinimumDate = checkoutMinimo;

        if (dtpck_checkout.Date is not DateTime checkoutAtual || checkoutAtual.Date < checkoutMinimo)
            dtpck_checkout.Date = checkoutMinimo;
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        if (pck_quarto.SelectedItem is not Quarto quarto)
        {
            await DisplayAlertAsync("Acomodação", "Selecione um quarto para continuar.", "OK");
            return;
        }

        int adultos = (int)stp_adultos.Value;
        int criancas = (int)stp_criancas.Value;
        if (adultos + criancas > quarto.CapacidadeMaxima)
        {
            await DisplayAlertAsync("Capacidade do quarto", $"O {quarto.Nome} aceita até {quarto.CapacidadeMaxima} hóspede(s). Escolha outra acomodação ou ajuste a quantidade de pessoas.", "OK");
            return;
        }

        if (dtpck_checkin.Date is not DateTime dataEntrada ||
            dtpck_checkout.Date is not DateTime dataSaida)
        {
            await DisplayAlertAsync("Período incompleto", "Informe as datas de check-in e check-out.", "OK");
            return;
        }

        DateTime entrada = dataEntrada.Date;
        DateTime saida = dataSaida.Date;
        if (entrada < DateTime.Today || saida <= entrada)
        {
            await DisplayAlertAsync("Período inválido", "O check-in não pode ser anterior a hoje e o check-out deve ocorrer após o check-in.", "OK");
            return;
        }

        var hospedagem = new Hospedagem
        {
            Adultos = adultos,
            Criancas = criancas,
            QuartoSelecionado = quarto,
            CheckIn = entrada,
            CheckOut = saida
        };

        // Objetivo da Agenda 13: enviar um objeto entre telas via BindingContext.
        await Navigation.PushAsync(new HospedagemContratada
        {
            BindingContext = hospedagem
        });
    }
}
