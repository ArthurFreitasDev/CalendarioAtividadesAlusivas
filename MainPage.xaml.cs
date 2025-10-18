using System.Text.Json;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using CalendarioAtividadesAlusivas.Models;
using static CalendarioAtividadesAlusivas.Models.Dias;
using System.Threading.Tasks;
using CalendarioAtividadesAlusivas.Helpers;
namespace CalendarioAtividadesAlusivas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AdicionarDias();
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
                        new Dias { Dia = 1, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 2, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 3, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 4, Dia_Semana = "Sábado", DataEspecial = "Nulo" },
                        new Dias { Dia = 5, Dia_Semana = "Domingo", DataEspecial = "Nulo" },
                        new Dias { Dia = 6, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 7, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 8, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 9, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 10, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 11, Dia_Semana = "Sábado", DataEspecial = "Nulo" },
                        new Dias { Dia = 12, Dia_Semana = "Domingo", DataEspecial = "Nulo" },
                        new Dias { Dia = 13, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 14, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 15, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 16, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 17, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 18, Dia_Semana = "Sábado", DataEspecial = "Nulo" },
                        new Dias { Dia = 19, Dia_Semana = "Domingo", DataEspecial = "Nulo" },
                        new Dias { Dia = 20, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 21, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 22, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 23, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 24, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 25, Dia_Semana = "Sábado", DataEspecial = "Nulo" },
                        new Dias { Dia = 26, Dia_Semana = "Domingo", DataEspecial = "Nulo" },
                        new Dias { Dia = 27, Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 28, Dia_Semana = "Terça-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 29, Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 30, Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo" },
                        new Dias { Dia = 31, Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo" }
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
    }
}
