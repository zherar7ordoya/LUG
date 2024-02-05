using System.Windows;
using ArchivoDLL;

namespace ArchivoEXE
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                Cita.MostrarCita(),
                "Cita",
                MessageBoxButton.OK,
                MessageBoxImage.Information,
                MessageBoxResult.OK,
                MessageBoxOptions.RightAlign);
        }
    }
}
