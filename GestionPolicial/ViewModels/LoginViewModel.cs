using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GestionPolicial.Application;
using GestionPolicial.Domain.Model;
using GestionPolicial.ViewModels.Interfaces;
using GestionPolicial.Views;

namespace GestionPolicial.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string TextBlockNombre { get; set; }
        public string TextBlockPassword { get; set; }
        public ICommand CommandLogin { get; set; }
        


        public LoginViewModel()
        {
         

            TextBlockNombre = "Nombre de usuario: ";
            TextBlockPassword = "Contraseña";
            CommandLogin = new Command(Login);
        }

        public void Login()
        {
            var usuario = new Usuario {NombreUsuario = NombreUsuario, Password = Password};
            var app = new UsuarioApp();
           var result=  app.Login(usuario);
            if (result == true) CurrentWindow.Content = new MainMenu() { DataContext = new MainMenuViewModel { CurrentWindow = CurrentWindow } };
            else new Views.Alert("Login incorrecto.").ShowDialog();

        }

    }
}
