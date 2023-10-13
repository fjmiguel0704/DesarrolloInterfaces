namespace EjerciciosUd6
{
    public partial class MainPage : ContentPage
    {
        public Boolean yaExisteBtn3 = false;
        public MainPage()
        {
            InitializeComponent();  
        }
        private void OnCounterClicked(object sender, EventArgs e) {
            if (yaExisteBtn3 == false)
            {
                Button boton = new Button
                {
                    Text = "Boton3",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    BackgroundColor = Colors.Blue,
                    HeightRequest = 70,
                    WidthRequest = 200,
                    FontFamily = "Verdana",
                    FontSize = 16,
                    FontAttributes = FontAttributes.Bold,
                    BorderColor = Colors.Yellow,
                    Margin = 30
                };
                
            }
        }

    }
}