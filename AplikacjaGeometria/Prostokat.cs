using System;

namespace AplikacjaGeometria.Modele
{
    // Klasa reprezentująca prostokąt
    public class Prostokat
    {
        // Szerokość prostokąta
        public double Szerokosc { get; set; }
        // Wysokość prostokąta
        public double Wysokosc { get; set; }

        // Metoda obliczająca obwód prostokąta
        public double ObliczObwod() => 2 * (Szerokosc + Wysokosc);

        // Metoda obliczająca pole prostokąta
        public double ObliczPole() => Szerokosc * Wysokosc;
    }
}