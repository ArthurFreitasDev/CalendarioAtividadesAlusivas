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
        int ContaLinha5 = 0, ContaLinha6 = 0;
        ObservableCollection<Dias> lista_dias_linha1 = new ObservableCollection<Dias>();
        ObservableCollection<Dias> lista_dias_linha2 = new ObservableCollection<Dias>();
        ObservableCollection<Dias> lista_dias_linha3 = new ObservableCollection<Dias>();
        ObservableCollection<Dias> lista_dias_linha4 = new ObservableCollection<Dias>();
        ObservableCollection<Dias> lista_dias_linha5 = new ObservableCollection<Dias>();
        ObservableCollection<Dias> lista_dias_linha6 = new ObservableCollection<Dias>();
        public MainPage()
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
                lista_dias_linha1.Clear();
                var AllDiasLinha1 = App.DBDias.GetAllDiasAsync().Result;
                foreach(Dias i in AllDiasLinha1)
                {
                    if(i.LinhaCalendario == 1)
                    {
                        lista_dias_linha1.Add(i);
                    }
                }
                lista_dias_linha2.Clear();
                var AllDiasLinha2 = App.DBDias.GetAllDiasAsync().Result;
                foreach (Dias i in AllDiasLinha2)
                {
                    if (i.LinhaCalendario == 2)
                    {
                        lista_dias_linha2.Add(i);
                    }
                }
                lista_dias_linha3.Clear();
                var AllDiasLinha3 = App.DBDias.GetAllDiasAsync().Result;
                foreach (Dias i in AllDiasLinha3)
                {
                    if (i.LinhaCalendario == 3)
                    {
                        lista_dias_linha3.Add(i);
                    }
                }
                lista_dias_linha4.Clear();
                var AllDiasLinha4 = App.DBDias.GetAllDiasAsync().Result;
                foreach (Dias i in AllDiasLinha4)
                {
                    if (i.LinhaCalendario == 4)
                    {
                        lista_dias_linha4.Add(i);
                    }
                }
                lista_dias_linha5.Clear();
                var AllDiasLinha5 = App.DBDias.GetAllDiasAsync().Result;
                foreach (Dias i in AllDiasLinha5)
                {
                    if (i.LinhaCalendario == 5)
                    {
                        lista_dias_linha5.Add(i);
                        ContaLinha5 = ContaLinha5 + 1;
                    }
                }
                if(ContaLinha5 < 7)
                {
                    lst_dias_linha5_MainPage.HorizontalOptions = LayoutOptions.StartAndExpand;
                }
                lista_dias_linha6.Clear();
                var AllDiasLinha6 = App.DBDias.GetAllDiasAsync().Result;
                foreach (Dias i in AllDiasLinha6)
                {
                    if (i.LinhaCalendario == 6)
                    {
                        lista_dias_linha6.Add(i);
                        ContaLinha6 = ContaLinha6 + 1;
                    }
                    if(i.Dia == 31)
                    {
                        for (int j = ContaLinha6; j <= 7; j++)
                        {
                            lista_dias_linha6.Add(new Dias { DataEspecial = "", Dia_Semana = "", LinhaCalendario = 6, Mes = "" });
                        }
                    }
                }

                


                //var AllDias = App.DBDias.GetAllDiasAsync().Result;
                //foreach(Dias i in AllDias)
                //{
                //    if(i.LinhaCalendario == 1)
                //    {
                //        if(i.Dia_Semana == "Sábado" || !Sabado)
                //        {
                //            lista_dias.Add(i);
                //            Sabado = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = ""});
                //            Sabado = true;
                //        }
                //        if (i.Dia_Semana == "Sexta-Feira" || !Sexta)
                //        {
                //            lista_dias.Add(i);
                //            Sexta = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Sexta = true;
                //        }
                //        if (i.Dia_Semana == "Quinta-Feira" || !Quinta)
                //        {
                //            lista_dias.Add(i);
                //            Quinta = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Quinta = true;
                //        }
                //        if (i.Dia_Semana == "Quarta-Feira" || !Quarta)
                //        {
                //            lista_dias.Add(i);
                //            Quarta = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Quarta = true;
                //        }
                //        if (i.Dia_Semana == "Terça-Feira" || !Terca )
                //        {
                //            lista_dias.Add(i);
                //            Terca = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Terca = true;
                //        }
                //        if (i.Dia_Semana == "Segunda-Feira" || !Segunda)
                //        {
                //            lista_dias.Add(i);
                //            Segunda = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Segunda = true;
                //        }
                //        if (i.Dia_Semana == "Domingo" || !Domingo)
                //        {
                //            lista_dias.Add(i);
                //            Domingo = true;
                //        }
                //        else
                //        {
                //            lista_dias.Add(new Dias { DataEspecial = "", Dia = 0, Dia_Semana = "", LinhaCalendario = 0, Mes = "" });
                //            Domingo = true;
                //        }
                //    }
                //}
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
