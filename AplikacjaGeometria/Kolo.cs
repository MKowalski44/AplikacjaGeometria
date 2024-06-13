using System;

namespace AplikacjaGeometria.Modele
{
    // Klasa reprezentująca koło
    public class Kolo
    {
        // Promień koła
        public double Promien { get; set; }

        // Metoda obliczająca obwód koła
        public double ObliczObwod() => 2 * Math.PI * Promien;

        // Metoda obliczająca pole koła
        public double ObliczPole() => Math.PI * Math.Pow(Promien, 2);
    }
}
