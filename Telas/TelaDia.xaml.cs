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
        Dias data_especial = BindingContext as Dias;
        DisplayAlert("a", data_especial.DataEspecial, "ok");
    }
}