using AplikacjaGeometria.Modele;
using System.Windows.Controls;

namespace AplikacjaGeometria.Widoki
{
    public partial class WidokProstokat : UserControl
    {
        public WidokProstokat()
        {
            InitializeComponent();
        }

        // Obsługa kliknięcia przycisku "Oblicz"
        private void Oblicz_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Sprawdzenie czy szerokość i wysokość są prawidłowymi liczbami
            if (double.TryParse(SzerokoscInput.Text, out double szerokosc) &&
                double.TryParse(WysokoscInput.Text, out double wysokosc))
            {
                // Utworzenie instancji klasy Prostokat i ustawienie wartości
                Prostokat prostokat = new Prostokat { Szerokosc = szerokosc, Wysokosc = wysokosc };
                // Wyświetlenie obwodu i pola
                WynikLabel.Content = $"Obwód: {prostokat.ObliczObwod()}, Pole: {prostokat.ObliczPole()}";
            }
            else
            {
                // Wyświetlenie błędu w przypadku nieprawidłowych danych
                WynikLabel.Content = "Niepoprawne dane.";
            }
        }
    }
}