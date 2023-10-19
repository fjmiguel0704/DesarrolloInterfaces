using _07_Pages.Views;

namespace _07_Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        async void irPaginaTabbed(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new PaginaTabbed());
        }
    }
}