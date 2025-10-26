using CalendarioAtividadesAlusivas.Helpers;
using CalendarioAtividadesAlusivas.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Text.Json;
using System.Threading.Tasks;
using static CalendarioAtividadesAlusivas.Models.Dias;
namespace CalendarioAtividadesAlusivas
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Dias> lista_dias = new ObservableCollection<Dias>();
        public MainPage()
        {
            InitializeComponent();
            AdicionarDias();
            lst_dias_MainPage.ItemsSource = lista_dias;
            
        }

        protected async override void OnAppearing()
        {
            try
            {
                lista_dias.Clear();
                var AllDias = App.DBDias.GetAllDiasAsync().Result;
                foreach(Dias i in AllDias)
                {
                    if(i.LinhaCalendario == 1)
                    {
                        lista_dias.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Ocorreu um erro ao carregar os dias: {ex.Message}", "OK");
            }
        }

        private async void AdicionarDias()
        {
            try
            {
                bool TemDados = await App.DBDias.TabelaTemDadosAsync();
                if(!TemDados)
                {
                    var ListaDias = new List<Dias>
                    {
                        new Dias { Dia = 1, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 }
                    };
                    await App.DBDias.InsertDias(ListaDias);
                    await DisplayAlert("Sucesso", "Dias adicionados com sucesso!", "OK");
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Ocorreu um erro ao adicionar os dias: {ex.Message}", "OK");
            }
        }

        private void lst_dias_MainPage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
