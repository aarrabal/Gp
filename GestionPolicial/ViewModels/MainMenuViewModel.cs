using GestionPolicial.ViewModels.Interfaces;
using System.Windows.Input;
using GestionPolicial.Views;

namespace GestionPolicial.ViewModels
{
    public class MainMenuViewModel: ViewModelBase { 
    
        public ICommand  CommandAltaPersona {get; set;}
        public ICommand CommandAltaDetenido { get; set; }
        public ICommand CommandAltaAgente { get; set; }
        public ICommand CommandAltaUsuario { get; set; }
        public ICommand CommandConfiguracion { get; set; } 

        public MainMenuViewModel()
        {
            CommandAltaPersona = new Command(AltaPersona);
            CommandAltaDetenido = new Command(AltaDetenido);
            CommandAltaAgente = new Command(AltaAgente);
            CommandAltaUsuario = new Command(AltaUsuario);
            CommandConfiguracion= new Command(Configuracion);

        }

        private void Configuracion()
        {
           
        }

        private void AltaUsuario()
        {
            CurrentWindow.Content = new UsersView { DataContext = new UsersViewModel() { CurrentWindow = CurrentWindow } };

        }

        private void AltaAgente()
        {
            CurrentWindow.Content = new UsersView();
        }

        private void AltaDetenido()
        {
            CurrentWindow.Content = new UsersView();
        }

        private void AltaPersona()
        {
            CurrentWindow.Content = new UsersView();
        }
    }
}