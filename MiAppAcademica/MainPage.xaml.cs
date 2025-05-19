using Microsoft.Maui.Controls;
using System;

namespace MiAppAcademica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string usuario = UsernameEntry.Text?.Trim()!;
            string contrasena = PasswordEntry.Text;

            // Verifica que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                await DisplayAlert("Advertencia", "Por favor, complete todos los campos.", "Aceptar");
                return;
            }

            // Validación hardcodeada
            if (usuario == "admin" && contrasena == "1234")
            {
                await Navigation.PushAsync(new MenuPrincipalPage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "Aceptar");
            }
        }
    }
}
