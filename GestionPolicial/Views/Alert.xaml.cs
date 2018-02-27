using System.Windows;

namespace GestionPolicial.Views
{
    /// <summary>
    /// Lógica de interacción para Alert.xaml
    /// </summary>
    public partial class Alert : Window
    {
        public Alert(string message)
        {
            InitializeComponent();
            TextBlockAlert.Text = message;
    


        }

       

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
          this.Close();
        }
    }
}
