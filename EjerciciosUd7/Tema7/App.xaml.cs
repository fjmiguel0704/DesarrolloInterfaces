namespace Tema7.Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaTabbed();
        }
    }
}