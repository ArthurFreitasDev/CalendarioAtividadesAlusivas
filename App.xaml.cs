using CalendarioAtividadesAlusivas.Helpers;
using CalendarioAtividadesAlusivas.Classes;
using CalendarioAtividadesAlusivas;
using CalendarioAtividadesAlusivas.Telas;
namespace CalendarioAtividadesAlusivas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        static HelperDias _dbDias;
        public static HelperDias DBDias
        {
            get
            {
                if(_dbDias == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dias.db3");
                    _dbDias = new HelperDias(path);
                }
                return _dbDias;
            }
        }

        public static ControleMes Controle_Mes = new ControleMes();
    }
}