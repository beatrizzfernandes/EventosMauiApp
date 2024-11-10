using EventosMauiApp.Models;
using EventosMauiApp.Views;
namespace EventosMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e) 
        {
            var evento = (Evento)BindingContext;
            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }

}
