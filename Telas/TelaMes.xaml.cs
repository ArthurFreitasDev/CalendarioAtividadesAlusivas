using CalendarioAtividadesAlusivas.Helpers;
using CalendarioAtividadesAlusivas.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Text.Json;
using System.Threading.Tasks;
using static CalendarioAtividadesAlusivas.Models.Dias;
namespace CalendarioAtividadesAlusivas.Telas;

public partial class TelaMes : ContentPage
{
    int ContaLinha5 = 0, ContaLinha6 = 0;
    ObservableCollection<Dias> lista_dias_linha1 = new ObservableCollection<Dias>();
    ObservableCollection<Dias> lista_dias_linha2 = new ObservableCollection<Dias>();
    ObservableCollection<Dias> lista_dias_linha3 = new ObservableCollection<Dias>();
    ObservableCollection<Dias> lista_dias_linha4 = new ObservableCollection<Dias>();
    ObservableCollection<Dias> lista_dias_linha5 = new ObservableCollection<Dias>();
    ObservableCollection<Dias> lista_dias_linha6 = new ObservableCollection<Dias>();
    public TelaMes()
	{
		InitializeComponent();

        AdicionarDias();
        
        lst_dias_linha1_MainPage.ItemsSource = lista_dias_linha1;
        lst_dias_linha2_MainPage.ItemsSource = lista_dias_linha2;
        lst_dias_linha3_MainPage.ItemsSource = lista_dias_linha3;
        lst_dias_linha4_MainPage.ItemsSource = lista_dias_linha4;
        lst_dias_linha5_MainPage.ItemsSource = lista_dias_linha5;
        lst_dias_linha6_MainPage.ItemsSource = lista_dias_linha6;
    }

    protected async override void OnAppearing()
    {
        try
        {
            string MesAtual = App.Controle_Mes.getTrocaTela_MesAtual();
            lista_dias_linha1.Clear();
            var AllDiasLinha1 = App.DBDias.GetAllDiasAsync().Result;
            foreach (Dias i in AllDiasLinha1)
            {
                if (i.LinhaCalendario == 1 && MesAtual == i.Mes)
                {
                    lista_dias_linha1.Add(i);
                }
            }
            lista_dias_linha2.Clear();
            var AllDiasLinha2 = App.DBDias.GetAllDiasAsync().Result;
            foreach (Dias i in AllDiasLinha2)
            {
                if (i.LinhaCalendario == 2 && MesAtual == i.Mes)
                {
                    lista_dias_linha2.Add(i);
                }
            }
            lista_dias_linha3.Clear();
            var AllDiasLinha3 = App.DBDias.GetAllDiasAsync().Result;
            foreach (Dias i in AllDiasLinha3)
            {
                if (i.LinhaCalendario == 3 && MesAtual == i.Mes)
                {
                    lista_dias_linha3.Add(i);
                }
            }
            lista_dias_linha4.Clear();
            var AllDiasLinha4 = App.DBDias.GetAllDiasAsync().Result;
            foreach (Dias i in AllDiasLinha4)
            {
                if (i.LinhaCalendario == 4 && MesAtual == i.Mes)
                {
                    lista_dias_linha4.Add(i);
                }
            }
            lista_dias_linha5.Clear();
            var AllDiasLinha5 = App.DBDias.GetAllDiasAsync().Result;
            foreach (Dias i in AllDiasLinha5)
            {
                if (i.LinhaCalendario == 5 && MesAtual == i.Mes)
                {
                    lista_dias_linha5.Add(i);
                    ContaLinha5 = ContaLinha5 + 1;
                }
            }
            if (ContaLinha5 < 7)
            {
                lst_dias_linha5_MainPage.HorizontalOptions = LayoutOptions.StartAndExpand;
            }
            lista_dias_linha6.Clear();
            var AllDiasLinha6 = App.DBDias.GetAllDiasAsync().Result;
            lst_dias_linha6_MainPage.HorizontalOptions = LayoutOptions.StartAndExpand;
            foreach (Dias i in AllDiasLinha6)
            {
                if (i.LinhaCalendario == 6 && MesAtual == i.Mes)
                {
                    lista_dias_linha6.Add(i);
                    ContaLinha6 = ContaLinha6 + 1;
                }
                if (ContaLinha6 < 7 && MesAtual == i.Mes)
                {
                    for (int j = ContaLinha6; j <= 7; j++)
                    {
                        lista_dias_linha6.Add(new Dias { DataEspecial = "", Dia_Semana = "", LinhaCalendario = 6, Mes = "" });
                    }
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
            if (!TemDados)
            {
                var ListaDias = new List<Dias>
                    {
                        new Dias { Dia = 1, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "teste", LinhaCalendario = 1, linkVideo = "https://www.youtube.com/", Texto = "Um bolo simples fofinho e quentinho com uma xícara de café pode ser tudo o que você precisa numa tarde chuvosa. E essa aqui é a receita que pode dar isso para você. Essa receita é bem simples e não leva muitos ingredientes. A massa branca pode ser usada com recheios de diferentes sabores e irá combinar com todos, já que não tem nenhum sabor dominante mais forte. Há quem diga que a massa branca é \"sem graça\", mas se você quiser, pode incrementar o bolo com alguma cobertura de brigadeiro, beijinho, leite condensado para dar mais sabor e deixar o bolo ainda mais molhadinho. Com bastante cuidado e pré-aquecendo o forno antes de colocar ele para assar, você consegue evitar que o bolo sole. Confira como fazer essa receita de bolo simples, também conhecido como bolo de farinha de trigo. Ele cai muito bem com um café quentinho!" },
                        new Dias { Dia = 2, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 3, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 4, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 5, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 10, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 11, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 12, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 17, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 18, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 19, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 24, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 25, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 26, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 3, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 4, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 5, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 10, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 11, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 12, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 17, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 18, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 19, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 24, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 25, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 26, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 6 },
                        new Dias { Dia = 31, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 6 },
                        new Dias { Dia = 1, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 6, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 13, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 20, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 27, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 5, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 12, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 19, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 26, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 6, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 7, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 8, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 13, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 14, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 15, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 20, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 21, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 22, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 27, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 28, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 29, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 6, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 13, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 20, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 27, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 4, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 5, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 11, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 12, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 18, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 19, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 25, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 26, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 6 },
                        new Dias { Dia = 1, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 6, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 7, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 13, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 14, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 20, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 21, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 27, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 28, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 1, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 3, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 4, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 5, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 6, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 7, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 10, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 11, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 12, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 13, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 14, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 17, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 18, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 19, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 20, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 21, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 24, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 25, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 26, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 27, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 28, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 6 },
                        new Dias { Dia = 1, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 2, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 3, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 4, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 5, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 6, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 1 },
                        new Dias { Dia = 7, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 8, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 9, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 10, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 11, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 12, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 13, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 2 },
                        new Dias { Dia = 14, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 15, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 16, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 17, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 18, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 19, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 20, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 3 },
                        new Dias { Dia = 21, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 22, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 23, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 24, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 25, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 26, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 27, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "Nulo", LinhaCalendario = 4 },
                        new Dias { Dia = 28, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 29, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 30, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
                        new Dias { Dia = 31, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Nulo", LinhaCalendario = 5 },
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

    private async void lst_dias_MainPage_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var Dia_Selecionado = e.CurrentSelection.FirstOrDefault() as Dias;
        await Navigation.PushAsync(new Telas.TelaDia
        {
            BindingContext = Dia_Selecionado
        });
    }

}