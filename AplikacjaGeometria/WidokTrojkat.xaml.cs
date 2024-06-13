using AplikacjaGeometria.Modele;
using System.Windows.Controls;

namespace AplikacjaGeometria.Widoki
{
    public partial class WidokTrojkat : UserControl
    {
        public WidokTrojkat()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (double.TryParse(BokAInput.Text, out double bokA) &&
                double.TryParse(BokBInput.Text, out double bokB) &&
                double.TryParse(PodstawaInput.Text, out double podstawa) &&
                double.TryParse(WysokoscInput.Text, out double wysokosc))
            {
                Trojkat trojkat = new Trojkat { BokA = bokA, BokB = bokB, Podstawa = podstawa, Wysokosc = wysokosc };
                WynikLabel.Content = $"Obwód: {trojkat.ObliczObwod()}, Pole: {trojkat.ObliczPole()}";
            }
            else
            {
                WynikLabel.Content = "Niepoprawne dane.";
            }
        }
    }
}