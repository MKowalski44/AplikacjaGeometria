using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AplikacjaGeometria
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PokazWidokKolo(object sender, RoutedEventArgs e)
        {
            ObszarZawartosci.Content = new Widoki.WidokKolo();
        }

        private void PokazWidokProstokat(object sender, RoutedEventArgs e)
        {
            ObszarZawartosci.Content = new Widoki.WidokProstokat();
        }

        private void PokazWidokTrojkat(object sender, RoutedEventArgs e)
        {
            ObszarZawartosci.Content = new Widoki.WidokTrojkat();
        }

        private void ZmienMotyw(object sender, RoutedEventArgs e)
        {
            // Implementacja zmiany motywu
        }
    }
}