using CalendarioAtividadesAlusivas.Models;
using CalendarioAtividadesAlusivas.Telas;
namespace CalendarioAtividadesAlusivas.Telas;

public partial class TelaAno : ContentPage
{
	public TelaAno()
	{
		InitializeComponent();
	}

    private async void Ano_MesJaneiro(object sender, EventArgs e)
    {
        string mes = "Janeiro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
}