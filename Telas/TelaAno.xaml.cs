using CalendarioAtividadesAlusivas.Models;
using CalendarioAtividadesAlusivas.Telas;
namespace CalendarioAtividadesAlusivas.Telas;

public partial class TelaAno : ContentPage
{
	public TelaAno()
	{
		InitializeComponent();
        AdicionarDias();
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

    private async void AdicionarDias()
    {
        try
        {
            bool TemDados = await App.DBDias.TabelaTemDadosAsync();
            if (!TemDados)
            {
                var ListaDias = new List<Dias>
                {
                    new Dias { Dia = 1, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 19, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 20, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 21, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Janeiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 26, Mes = "Janeiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 27, Mes = "Janeiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Janeiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Janeiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Dia nacional da Visibilidade Trans", LinhaCalendario = 5, linkVideo = "https://youtu.be/Mmb_0xJMFsg", Texto = "Celebrado em todo o Brasil, o Dia Nacional da Visibilidade Trans reforça o respeito, a inclusão e os direitos das pessoas trans e travestis. Em Bauru, a data destaca a importância da diversidade e do reconhecimento das identidades de gênero, promovendo uma cidade mais justa e acolhedora para todos." },
                    new Dias { Dia = 30, Mes = "Janeiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Janeiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 1, linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 2, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2, linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro."  },
                    new Dias { Dia = 3, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2, linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 4, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2,linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 5, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2,linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 6, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2,linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 7, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "Semana Nacional de prevenção da gravidez na adolescência", LinhaCalendario = 2, linkVideo = "https://youtu.be/jBBm5K7CzkY", Texto = "A Semana Nacional de Prevenção da Gravidez na Adolescência promove ações educativas sobre saúde sexual e reprodutiva. Em Bauru, reforça-se a importância do diálogo, da informação e do apoio aos jovens para decisões conscientes e seguras sobre o próprio corpo e o futuro." },
                    new Dias { Dia = 8, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 10, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 11, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 12, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 17, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 18, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 19, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 20, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 21, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Fevereiro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Fevereiro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 24, Mes = "Fevereiro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 25, Mes = "Fevereiro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 26, Mes = "Fevereiro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 27, Mes = "Fevereiro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Fevereiro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 3, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 4, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 5, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 2, linkVideo = "https://youtu.be/c71ip24tvec" , Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 9, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec" , Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 10, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec" , Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 11, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec", Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 12, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec", Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 13, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec", Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 14, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal da Mulher", LinhaCalendario = 3, linkVideo = "https://youtu.be/c71ip24tvec", Texto = "A Semana Municipal da Mulher celebra as conquistas sociais, políticas e econômicas das mulheres, ao mesmo tempo em que reforça a importância da igualdade de direitos, do combate à violência de gênero e da valorização feminina em todos os espaços da sociedade. Em Bauru, a data promove ações educativas, culturais e de conscientização em prol do empoderamento das mulheres." },
                    new Dias { Dia = 15, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 17, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 18, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 19, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 20, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 21, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 24, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 25, Mes = "Março", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 5, linkVideo ="https://youtu.be/dGhs0GzVLD0", Texto ="O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar." },
                    new Dias { Dia = 26, Mes = "Março", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 5, linkVideo ="https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar."},
                    new Dias { Dia = 27, Mes = "Março", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 5 , linkVideo = "https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar."},
                    new Dias { Dia = 28, Mes = "Março", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 5 , linkVideo = "https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar."},
                    new Dias { Dia = 29, Mes = "Março", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 5 , linkVideo = "https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar."},
                    new Dias { Dia = 30, Mes = "Março", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 6, linkVideo ="https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar." },
                    new Dias { Dia = 31, Mes = "Março", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal de Alienação Parental", LinhaCalendario = 6 , linkVideo = "https://youtu.be/dGhs0GzVLD0", Texto = "O Dia de Combate à Alienação Parental alerta para os prejuízos causados à convivência familiar quando um dos responsáveis interfere no vínculo da criança ou adolescente com o outro genitor. Em Bauru, a data reforça a importância do diálogo, do afeto e do respeito no ambiente familiar."},
                    new Dias { Dia = 1, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 6, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 13, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 19, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 20, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 21, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Abril", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Abril", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 26, Mes = "Abril", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 27, Mes = "Abril", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Abril", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Abril", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Abril", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 5, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 12, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Dia do Assistente Social", LinhaCalendario = 3, linkVideo ="https://youtu.be/avg65sGtzSA", Texto ="O Dia do Assistente Social reconhece o compromisso desses profissionais com a justiça social, a defesa dos direitos humanos e a promoção da cidadania. Em Bauru, a data celebra o trabalho essencial realizado em prol da dignidade và inclusão de todas as pessoas." },
                    new Dias { Dia = 16, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4, linkVideo ="https://youtu.be/Xsnp2pBXAEg", Texto="A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade." },
                    new Dias { Dia = 19, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4, linkVideo ="https://youtu.be/Xsnp2pBXAEg", Texto= "A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade." },
                    new Dias { Dia = 20, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4, linkVideo ="https://youtu.be/Xsnp2pBXAEg", Texto="A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade." },
                    new Dias { Dia = 21, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4, linkVideo ="https://youtu.be/Xsnp2pBXAEg", Texto="A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade." },
                    new Dias { Dia = 22, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4, linkVideo ="https://youtu.be/Xsnp2pBXAEg", Texto="A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade." },
                    new Dias { Dia = 23, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4 , linkVideo = "https://youtu.be/Xsnp2pBXAEg", Texto="A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade."},
                    new Dias { Dia = 24, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal de combate ao abuso e exploração sexual a crianças e adolescentes", LinhaCalendario = 4 , linkVideo = "https://youtu.be/Xsnp2pBXAEg", Texto= "A Semana Municipal de Combate ao Abuso e à Exploração Sexual de Crianças e Adolescentes reforça a importância da proteção e do cuidado com a infância e a juventude. Em Bauru, a mobilização promove conscientização, denúncia e prevenção, garantindo o direito de crescer com segurança e dignidade."},
                    new Dias { Dia = 25, Mes = "Maio", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 26, Mes = "Maio", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 27, Mes = "Maio", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Maio", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Maio", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Maio", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Maio", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 6, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 7, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 8, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 2, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 13, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 2, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 14, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 2, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 15, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "Dia nacional e internacional de consciência da violência contra a pessoa idosa", LinhaCalendario = 3, linkVideo ="https://youtu.be/UHt1jFHH7JA", Texto = "O Dia Nacional e Internacional de Conscientização da Violência contra a Pessoa Idosa alerta para a importância do respeito, da proteção e da valorização da pessoa idosa. Em Bauru, a data reforça o compromisso com o envelhecimento digno, livre de qualquer forma de abuso, negligência ou discriminação." },
                    new Dias { Dia = 16, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 3, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 17, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 3, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 18, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal de prevenção e erradicação do trabalho infantil", LinhaCalendario = 3, linkVideo ="https://youtu.be/2vyaDvbMc34", Texto = "A Semana Municipal de Prevenção e Erradicação do Trabalho Infantil reforça o compromisso de Bauru com a garantia dos direitos das crianças e adolescentes. A data promove ações educativas e de conscientização para combater o trabalho infantil e assegurar um futuro com educação, lazer e proteção." },
                    new Dias { Dia = 19, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 20, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 21, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 22, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Junho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Junho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 26, Mes = "Junho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 27, Mes = "Junho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 28, Mes = "Junho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 29, Mes = "Junho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Junho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 6, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 13, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 19, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 20, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 21, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Julho", Dia_Semana = "Sábado", DataEspecial = "Dia Mundial da Cultura e de Paz", LinhaCalendario = 4, linkVideo = "https://youtu.be/qocsIX_X2Ww", Texto = "O Dia Mundial da Cultura e de Paz celebra o diálogo, o respeito e a convivência harmônica entre os povos. Em Bauru, a data inspira ações culturais e educativas que promovem a empatia, a solidariedade e o compromisso com uma sociedade mais justa e pacífica."},
                    new Dias { Dia = 26, Mes = "Julho", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 27, Mes = "Julho", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Julho", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Julho", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Julho", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Julho", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Aniversário de Bauru", LinhaCalendario = 1, linkVideo = "https://youtu.be/4NIKElFE8bM", Texto = "O Aniversário de Bauru celebra a história, a cultura e a diversidade que formam a identidade da cidade. A data homenageia o trabalho e a dedicação de todos os bauruenses que, com orgulho e união, contribuem para o desenvolvimento e a construção de uma Bauru cada vez melhor." },
                    new Dias { Dia = 2, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 4, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 5, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 11, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 12, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 18, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 19, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Dia Nacional de luta da população em situação de rua", LinhaCalendario = 4, linkVideo = "https://youtu.be/KFYyt3tst8k", Texto = "O Dia Nacional de Luta da População em Situação de Rua reforça a importância da dignidade, do respeito e da garantia de direitos para todas as pessoas. Em Bauru, a data mobiliza ações de inclusão social e conscientização sobre a necessidade de políticas públicas que promovam acolhimento e cidadania." },
                    new Dias { Dia = 20, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 4, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 21, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 4, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 22, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 4, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 23, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 4, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 24, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 5, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 25, Mes = "Agosto", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 5, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 26, Mes = "Agosto", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal de combate ao preconceito e discriminação", LinhaCalendario = 5, linkVideo = "https://youtu.be/k_37lN9-6R0", Texto = "A Semana Municipal de Combate ao Preconceito e à Discriminação promove o respeito às diferenças e o direito à igualdade. Em Bauru, a data incentiva a reflexão, o diálogo e ações que fortalecem a inclusão social e a convivência harmoniosa entre todas as pessoas." },
                    new Dias { Dia = 27, Mes = "Agosto", Dia_Semana = "Quinta-Feira", DataEspecial = "Dia do Psicólogo", LinhaCalendario = 5, linkVideo = "https://youtu.be/H9jbbyUmVmI", Texto = "O Dia do Psicólogo reconhece o trabalho essencial desses profissionais na promoção da saúde mental, do equilíbrio emocional e do bem-estar social. Em Bauru, a data valoriza o compromisso da Psicologia com o cuidado humano, o acolhimento e o fortalecimento das relações saudáveis." },
                    new Dias { Dia = 28, Mes = "Agosto", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Agosto", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Agosto", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Agosto", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 6 },
                    new Dias { Dia = 1, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 6, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 7, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 13, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 14, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 17, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 19, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 20, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 21, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 22, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 23, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 24, Mes = "Setembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 25, Mes = "Setembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 26, Mes = "Setembro", Dia_Semana = "Sábado", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 27, Mes = "Setembro", Dia_Semana = "Domingo", DataEspecial = "Dia Nacional de luta da pessoa com deficiência/Semana Municipal da pessoa com deficiência", LinhaCalendario = 4,linkVideo = "https://youtu.be/Jyie2esEwjM", Texto = "O Dia Nacional de Luta da Pessoa com Deficiência e a Semana Municipal da Pessoa com Deficiência reafirmam o compromisso com a inclusão, a acessibilidade e o respeito à diversidade. Em Bauru, as ações destacam a importância da participação social, da autonomia e da garantia de direitos para todas as pessoas com deficiência." },
                    new Dias { Dia = 28, Mes = "Setembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Setembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Setembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Dia Nacional do Idoso", LinhaCalendario = 1, linkVideo = "https://youtu.be/pjZWjDDH3-M", Texto = "O Dia Internacional do Idoso celebra o envelhecimento com dignidade, respeito e participação social. Em Bauru, a data valoriza a sabedoria e as contribuições das pessoas idosas, reforçando o compromisso com políticas públicas que garantam qualidade de vida e proteção a essa população." },
                    new Dias { Dia = 2, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 11, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 12, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 3,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 17, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 3,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 18, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 3,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 19, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 4,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 20, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 4,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 21, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 4 ,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 22, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "Semana Municipal de Segurança Alimentar e Nutricional", LinhaCalendario = 4 ,linkVideo = "https://youtu.be/cKssA-nLq7I", Texto = "A Semana Municipal de Segurança Alimentar e Nutricional reforça o direito de todos a uma alimentação adequada, saudável e de qualidade. Em Bauru, a data promove a conscientização sobre o combate à fome, o desperdício e a valorização da agricultura sustentável e da educação alimentar." },
                    new Dias { Dia = 23, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Outubro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 26, Mes = "Outubro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 27, Mes = "Outubro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Outubro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Outubro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Outubro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Outubro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 1, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 3, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 4, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 5, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 6, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 7, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 10, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 11, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 12, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 13, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 14, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 15, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 16, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 17, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 18, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 19, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 20, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Dia da Consciência Negra", LinhaCalendario = 4, linkVideo = "https://youtu.be/KW57b7BHmyI", Texto = "O Dia da Consciência Negra homenageia a luta e a resistência do povo negro e celebra a contribuição da cultura afro-brasileira na formação da nossa sociedade. Em Bauru, a data reforça o combate ao racismo e a valorização da igualdade, da história e da identidade negra." },
                    new Dias { Dia = 21, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 24, Mes = "Novembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 25, Mes = "Novembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Dia Internacional da não Violência contra a Mulher", LinhaCalendario = 5, linkVideo = "https://youtu.be/XxCDmxPAGxc", Texto = "O Dia Internacional da Não Violência contra a Mulher reforça a luta pelo fim de todas as formas de agressão física, psicológica, sexual e moral. Em Bauru, a data mobiliza ações de conscientização, acolhimento e apoio, promovendo o respeito e a igualdade de gênero em toda a sociedade." },
                    new Dias { Dia = 26, Mes = "Novembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 27, Mes = "Novembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 28, Mes = "Novembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Novembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Novembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 6 },
                    new Dias { Dia = 1, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 2, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 3, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 4, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 5, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 6, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 1 },
                    new Dias { Dia = 7, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 8, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 9, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 2 },
                    new Dias { Dia = 10, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 2, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 11, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 2, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 12, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 2, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 13, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 2, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 14, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "Dia Nacional de Combate à Pobreza", LinhaCalendario = 3, linkVideo = "https://youtu.be/DHambpDV7rw", Texto = "O Dia Nacional de Combate à Pobreza reforça a importância da solidariedade, da justiça social e da redução das desigualdades. Em Bauru, a data estimula ações voltadas à inclusão, ao acesso a direitos e à construção de uma sociedade mais justa e igualitária para todos." },
                    new Dias { Dia = 15, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 3, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 16, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "Dia Internacional de Direitos Humanos/Semana Bauruense de Direitos Humanos", LinhaCalendario = 3, linkVideo = "https://youtu.be/taV3ZmdWFuQ", Texto = "O Dia Internacional dos Direitos Humanos e a Semana Bauruense de Direitos Humanos celebram a dignidade, a igualdade e o respeito a todas as pessoas. Em Bauru, a data incentiva ações educativas e reflexivas sobre cidadania, justiça social e a construção de uma sociedade mais justa e solidária." },
                    new Dias { Dia = 17, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 18, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 19, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 20, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 3 },
                    new Dias { Dia = 21, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 22, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 23, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 24, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 25, Mes = "Dezembro", Dia_Semana = "Sexta-Feira", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 26, Mes = "Dezembro", Dia_Semana = "Sábado", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 27, Mes = "Dezembro", Dia_Semana = "Domingo", DataEspecial = "", LinhaCalendario = 4 },
                    new Dias { Dia = 28, Mes = "Dezembro", Dia_Semana = "Segunda-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 29, Mes = "Dezembro", Dia_Semana = "Terça-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 30, Mes = "Dezembro", Dia_Semana = "Quarta-Feira", DataEspecial = "", LinhaCalendario = 5 },
                    new Dias { Dia = 31, Mes = "Dezembro", Dia_Semana = "Quinta-Feira", DataEspecial = "", LinhaCalendario = 5 },
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