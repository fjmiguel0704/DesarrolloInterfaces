namespace _07_Pages.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

	async void irMainPage(object sender, EventArgs args) { 
		await Navigation.PushModalAsync(new MainPage());
	}
}