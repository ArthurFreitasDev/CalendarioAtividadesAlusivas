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
        try
        {
            string data_especial_texto = "";
            var dataEspecia_ = BindingContext as Dias;
            var dia_ = App.DBDias.GetAllDiasAsync().Result;
            foreach (var i in dia_)
            {
                if(dataEspecia_ != null)
                {
                    if (i.DataEspecial == dataEspecia_.DataEspecial)
                    {
                        data_especial_texto = i.Texto;
                        break;
                    }
                }
                
            }
            lblTextoPrincipal.Text = data_especial_texto;
        }
        catch
        {
            DisplayAlert("Aviso!", "Esse dia nao possui nenhuma data especial", "OK");
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string data_especial_link = "";
            var dataEspecia_ = BindingContext as Dias;
            var dia_ = App.DBDias.GetAllDiasAsync().Result;
            foreach (var i in dia_)
            {
                if (dataEspecia_ != null)
                {
                    if (i.DataEspecial == dataEspecia_.DataEspecial)
                    {
                        data_especial_link = i.linkVideo;
                        break;
                    }
                }

            }
            await Launcher.OpenAsync(data_especial_link);
        }
        catch
        {
            DisplayAlert("Aviso!", "Esse dia nao possui nenhuma data especial", "OK");
        }
    }
}