namespace _07_Pages.Views;
using Entidades;

public partial class Pagina5 : ContentPage
{
	public Pagina5() 
	{
		InitializeComponent();
	}

	async void irMainPage(object sender, EventArgs args) { 
		await Navigation.PushModalAsync(new MainPage());
	}
}