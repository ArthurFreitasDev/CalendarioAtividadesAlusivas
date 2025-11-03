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
        App.Controle_Mes.TrocaTela_MesAtual("Janeiro");
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}