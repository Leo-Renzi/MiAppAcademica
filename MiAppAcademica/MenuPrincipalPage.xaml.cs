using Microsoft.Maui.Controls;

namespace MiAppAcademica
{
    public partial class MenuPrincipalPage : ContentPage
    {
        public MenuPrincipalPage()
        {
            InitializeComponent();
        }

        private async void OnAcercaDesarrolladorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AcercaDesarrolladorPage());
        }

        private async void OnInformacionServicioClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformacionServicioPage());
        }

        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            // Volver a la página de inicio de sesión
            await Navigation.PopToRootAsync();
        }
    }
}