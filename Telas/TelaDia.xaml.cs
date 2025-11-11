using CalendarioAtividadesAlusivas.Models;
namespace CalendarioAtividadesAlusivas.Telas;

public partial class TelaDia : ContentPage
{
	public TelaDia()
    {
        InitializeComponent();
        
    }

    
    
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        var dataEspecia_ = BindingContext as Dias;
        var dia_ = App.DBDias.GetAllDiasAsync().Result.Where(d => d.DataEspecial == dataEspecia_.DataEspecial).FirstOrDefault();
        lblTextoPrincipal.Text = dia_.Texto;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var dataEspecia_ = BindingContext as Dias;
        var dia_ = App.DBDias.GetAllDiasAsync().Result.Where(d => d.DataEspecial == dataEspecia_.DataEspecial).FirstOrDefault();
        await Launcher.OpenAsync(dia_.linkVideo);
    }
}