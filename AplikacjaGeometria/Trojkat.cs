using System;

namespace AplikacjaGeometria.Modele
{
    // Klasa reprezentująca trójkąt
    public class Trojkat
    {
        // Bok A trójkąta
        public double BokA { get; set; }
        // Bok B trójkąta
        public double BokB { get; set; }
        // Podstawa trójkąta
        public double Podstawa { get; set; }
        // Wysokość trójkąta
        public double Wysokosc { get; set; }

        // Metoda obliczająca obwód trójkąta
        public double ObliczObwod() => BokA + BokB + Podstawa;

        // Metoda obliczająca pole trójkąta
        public double ObliczPole() => 0.5 * Podstawa * Wysokosc;
    }
}