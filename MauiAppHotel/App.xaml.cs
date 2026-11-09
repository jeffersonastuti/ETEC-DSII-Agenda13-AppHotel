using System.Globalization;
using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        var ptBr = CultureInfo.GetCultureInfo("pt-BR");
        CultureInfo.DefaultThreadCurrentCulture = ptBr;
        CultureInfo.DefaultThreadCurrentUICulture = ptBr;
    }

    // O .NET MAUI 10 recomenda configurar a pagina inicial pela janela.
    protected override Window CreateWindow(IActivationState? activationState)
    {
        var paginaInicial = new NavigationPage(new ContratacaoHospedagem())
        {
            BarBackgroundColor = Color.FromArgb("#172D40"),
            BarTextColor = Colors.White
        };

        return new Window(paginaInicial)
        {
            Title = "App Hotel | Agenda 13"
        };
    }
}
