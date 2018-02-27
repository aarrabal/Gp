using System;
using System.Windows.Input;

namespace GestionPolicial.ViewModels
{
    public class Command : ICommand
    {
        private Action _action { get; set; }
        public Command(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}