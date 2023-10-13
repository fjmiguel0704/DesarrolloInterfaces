namespace Calendario
{
    public partial class MainPage : ContentPage
    {
        public DateTime FechaHoy { get; } = DateTime.Now.Date;
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            entrada.DateSelected += (sender, e) =>
            {
                FechaEntrada = e.NewDate.Date;
                salida.MinimumDate = FechaEntrada;
            };

            salida.DateSelected += (sender, e) =>
            {
                FechaSalida = e.NewDate.Date;
            };

        }


    }
}