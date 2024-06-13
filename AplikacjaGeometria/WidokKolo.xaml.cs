using AplikacjaGeometria.Modele;
using System.Windows.Controls;

namespace AplikacjaGeometria.Widoki
{
    public partial class WidokKolo : UserControl
    {
        public WidokKolo()
        {
            InitializeComponent();
        }

        // Obsługa kliknięcia przycisku "Oblicz"
        private void Oblicz_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Sprawdzenie czy promień jest prawidłową liczbą
            if (double.TryParse(PromienInput.Text, out double promien))
            {
                // Utworzenie instancji klasy Kolo i ustawienie promienia
                Kolo kolo = new Kolo { Promien = promien };
                // Wyświetlenie obwodu i pola
                WynikLabel.Content = $"Obwód: {kolo.ObliczObwod()}, Pole: {kolo.ObliczPole()}";
            }
            else
            {
                // Wyświetlenie błędu w przypadku nieprawidłowych danych
                WynikLabel.Content = "Niepoprawne dane.";
            }
        }
    }
}
