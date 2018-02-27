using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using GestionPolicial.Domain.Model;
using GestionPolicial.ViewModels.Interfaces;
using GestionPolicial.Views;

namespace GestionPolicial.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {
        public Usuario CurrentUsuario { get; set; }

        public ICommand AddUsuarioCommand { get; set; }

        public ICommand BackCommand { get; set; }

        public UsersViewModel()
        {
            CurrentUsuario = new Usuario();
            AddUsuarioCommand = new Command(AddUsuario);

            BackCommand = new Command(Back);

        }

        private void AddUsuario()
        {

        }

        private void Back()
        {
            CurrentWindow.Content = new MainMenu() {DataContext = new MainMenuViewModel {CurrentWindow = CurrentWindow}};
        }

    }
}