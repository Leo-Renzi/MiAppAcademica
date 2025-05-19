using Microsoft.Maui.Controls;

namespace MiAppAcademica
{
    public partial class AcercaDesarrolladorPage : ContentPage
    {
        public AcercaDesarrolladorPage()
        {
            InitializeComponent();
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}