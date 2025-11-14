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
            lblNomeMes.Text = MesAtual;
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

    private async void lst_dias_MainPage_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var Dia_Selecionado = e.CurrentSelection.FirstOrDefault() as Dias;
        await Navigation.PushAsync(new Telas.TelaDia
        {
            BindingContext = Dia_Selecionado
        });
    }

}