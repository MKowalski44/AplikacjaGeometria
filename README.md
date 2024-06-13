# AplikacjaGeometria

Aplikacja Geometria to aplikacja WPF (Windows Presentation Foundation) napisana w języku C#.
Umożliwia ona obliczanie obwodów i pól różnych figur geometrycznych oraz dodatkowych informacji, takich jak długość przeciwprostokątnej lub promień kątów występujących w figurze.
Aplikacja posiada interfejs użytkownika z możliwością zmiany motywu (jasny/ciemny) i jest zbudowana zgodnie z architekturą MVC (Model-View-Controller).

Wymagania
Visual Studio 2019 lub nowszy
.NET Framework 4.7.2 lub nowszy

Struktura projektu
MainWindow.xaml - Główne okno aplikacji, zawiera menu oraz obszar do wyświetlania widoków.
MainWindow.xaml.cs - Kod-behind dla głównego okna, zawiera logikę przełączania widoków oraz zmiany motywu.
Widoki - Folder zawierający widoki dla różnych figur geometrycznych.
WidokKolo.xaml - Widok dla koła.
WidokKolo.xaml.cs - Kod-behind dla widoku koła.
Model - Folder zawierający modele dla figur geometrycznych.
Kolo.cs - Model dla koła zawierający metody obliczeniowe.
Użycie
Uruchom aplikację.
Wybierz figurę z menu "Figury" (np. Koło).
Wprowadź dane wejściowe (promień) w pole tekstowe.
Kliknij przycisk "Oblicz", aby zobaczyć wyniki obliczeń.
Aby zmienić motyw, wybierz odpowiednią opcję z menu "Motyw" (Jasny/Ciemny).
Przykład użycia
Obliczanie parametrów koła
Wybierz "Koło" z menu "Figury".
Wprowadź wartość promienia w polu "Promień".
Kliknij "Oblicz z Promienia", aby uzyskać obwód i pole koła.
Alternatywnie, wprowadź obwód lub pole i kliknij odpowiedni przycisk, aby obliczyć pozostałe parametry.
Zmiana motywu
Wybierz "Jasny" lub "Ciemny" z menu "Motyw".
Interfejs użytkownika zmieni się odpowiednio do wybranego motywu.
Rozwój
Jeśli chcesz dodać nowe funkcje lub figury do aplikacji, wykonaj następujące kroki:

Dodaj nowy model do folderu Model.
Utwórz nowy widok w folderze Widoki.
Zaimplementuj logikę w kod-behind dla nowego widoku.
Zaktualizuj MainWindow.xaml i MainWindow.xaml.cs, aby dodać nowe opcje w menu oraz logikę przełączania widoków.
Wkład
Chętnie przyjmujemy wkład od społeczności. Jeśli masz pomysły na ulepszenia lub znalazłeś błąd, otwórz nowe zgłoszenie w repozytorium lub stwórz pull request.
