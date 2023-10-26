namespace _07_Pages.Views;
using Entidades;

public partial class Pagina4 : ContentPage
{
	public Pagina4(Persona persona)
	{
		InitializeComponent();
		mostrarNombre.Text = persona.nombreCompleto;
    }

	async void irMainPage(object sender, EventArgs args) {
		await Navigation.PushModalAsync(new MainPage());
	}
}