using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using GestionPolicial.Properties;

namespace GestionPolicial.ViewModels.Interfaces
{
    public abstract class ViewModelBase:INotifyPropertyChanged
    {
        public Window CurrentWindow { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
