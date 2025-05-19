using Microsoft.Maui.Controls;

namespace MiAppAcademica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configuramos la navegación con la página inicial
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.Black,
                BarTextColor = Colors.White
            };
        }
    }
}
