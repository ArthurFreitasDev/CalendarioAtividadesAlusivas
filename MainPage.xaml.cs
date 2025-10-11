using System.Text.Json;
using CalendarioAtividadesAlusivas.Models;
using static CalendarioAtividadesAlusivas.Models.Dias;
namespace CalendarioAtividadesAlusivas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CarregarMeses();
        }

        private async void CarregarMeses()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("BancoDias.json");
            using var reader = new StreamReader(stream);
            string content = await reader.ReadToEndAsync();

            var calendario = JsonSerializer.Deserialize<Lista_Janeiro>(content);

            var primeiroDia = calendario.ListaJaneiro.Janeiro.First();
            await DisplayAlert("Primeiro Dia", $"Dia: {primeiroDia.Dia}, Dia da Semana: {primeiroDia.Dia_Semana}, Data Especial: {primeiroDia.Data_Especial}", "OK");
        }
    }
}
