using Microsoft.Maui.Controls;

namespace MiAppAcademica
{
    public partial class InformacionServicioPage : ContentPage
    {
        public InformacionServicioPage()
        {
            InitializeComponent();
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}