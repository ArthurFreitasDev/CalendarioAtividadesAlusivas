using System.Threading.Tasks;

namespace CalendarioAtividadesAlusivas;

public partial class TelaAno : ContentPage
{
	public TelaAno()
	{
		InitializeComponent();
	}

    private void Ano_MesJaneiro(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}