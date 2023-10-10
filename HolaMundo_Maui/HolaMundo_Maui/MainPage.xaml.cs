using System.Net.Security;
using BibliotecaClases;

namespace HolaMundo_Maui
{
    public partial class MainPage : ContentPage
    {
        Persona persona = new Persona();

        public MainPage()
        {   
            InitializeComponent();
        }

        private async void ApellidosClicked(object sender, EventArgs e) {
            persona.Nombre = nombreUsu.Text;

            persona.Apellidos = await DisplayPromptAsync("Apellidos", "Introduce tu primer apellido");

            await DisplayAlert("Nombre Completo", persona.nombreCompleto, "OK");

            Saludo.Text = persona.nombreCompleto.ToString();
        }

    }
}