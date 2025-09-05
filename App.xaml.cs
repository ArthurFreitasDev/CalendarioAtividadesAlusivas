namespace CalendarioAtividadesAlusivas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());

            var window = base.CreateWindow(activationState);

            const int newWidth = 1920;
            const int newHeight = 1080;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}