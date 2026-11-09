namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e) => await Navigation.PopAsync();

    private async void OnSobreClicked(object sender, EventArgs e) => await Navigation.PushAsync(new SobrePage());
}
