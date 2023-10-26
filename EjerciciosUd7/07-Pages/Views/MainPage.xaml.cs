using _07_Pages.Views;
using Entidades;

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

        async void irPage4(object sender, EventArgs args) {
            Persona per = new Persona(NombreUsu.Text, ApellidosUsu.Text);
            await Navigation.PushModalAsync(new Pagina4(per));
        }

        async void irPage5(object sender, EventArgs args)
        {
            Persona per = new Persona(NombreUsu.Text, ApellidosUsu.Text);
            await Navigation.PushModalAsync(new Pagina5 { 
                BindingContext = per
            });
        }   
    }
}