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
    private async void Ano_MesFevereiro(object sender, EventArgs e)
    {
        string mes = "Fevereiro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesMarco(object sender, EventArgs e)
    {
        string mes = "Março";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesAbril(object sender, EventArgs e)
    {
        string mes = "Abril";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesMaio(object sender, EventArgs e)
    {
        string mes = "Maio";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesJunho(object sender, EventArgs e)
    {
        string mes = "Junho";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesJulho(object sender, EventArgs e)
    {
        string mes = "Junho";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesAgosto(object sender, EventArgs e)
    {
        string mes = "Agosto";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesSetenbro(object sender, EventArgs e)
    {
        string mes = "Setembro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesOutubro(object sender, EventArgs e)
    {
        string mes = "Outubro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesNovenbro(object sender, EventArgs e)
    {
        string mes = "Novembro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
    private async void Ano_MesDezenbro(object sender, EventArgs e)
    {
        string mes = "Dezembro";
        App.Controle_Mes.TrocaTela_MesAtual(mes);
        await Navigation.PushAsync(new TelaMes());
    }
}