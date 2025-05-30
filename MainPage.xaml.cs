using System;
using Microsoft.Maui.Controls;

namespace CadastroEventosMaui
{
    public partial class MainPage : ContentPage
    {
        private Evento evento;

        public MainPage()
        {
            InitializeComponent();
            evento = new Evento
            {
                DataInicio = DateTime.Today,
                DataFim = DateTime.Today
            };
            BindingContext = evento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResultadoPage(evento));
        }
    }
}
