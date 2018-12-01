using System;
using System.Collections.Generic;

namespace Komis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pojazd> list = new List<Pojazd>();
            string option = "m";

            do
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Lista pojazdów:");
                        foreach (Pojazd poj in list)
                        {
                            Console.WriteLine("________________________________________");
                            Console.WriteLine($"Typ pojazdu: {poj.WyswietlTypPojazdu}" +
                                $"\nMarka: {poj.WyswietlMarke()} " +
                                $"\nModel: {poj.WyswietlModel()}" +
                                $"\nCena zakupu: {poj.CenaZakupu} zł" +
                                $"\nMarża: {poj.Marza}%" +
                                $"\nRok produkcji: {poj.RokProdukcji}" +
                                $"\nCena koncowa: {poj.podajCeneKoncowa()}");
                            if (poj.WyswietlModel()=="Panda") Console.WriteLine("___Never say no to Panda !! :)___ ");
                            Console.WriteLine("________________________________________");
                        }
                        option = "m";
                        break;
                    case "2":
                        Console.WriteLine("Dodaj nowy pojazd.");
                        list.Add(new Panda(5000, 10, 1999));
                        option = "m";
                        break;
                    case "3":
                        Console.WriteLine("Wyszukaj pojazd w komisie.");
                        option = "m";
                        break;
                    case "4":
                        Console.WriteLine("Sprzedaj pojazd.");
                        option = "m";
                        break;
                    case "m":
                        Console.WriteLine("Dostępne opcje:");
                        Console.WriteLine("1 : Wyświetl listę pojazdów");
                        Console.WriteLine("2 : Dodaj nowy pojazd");
                        Console.WriteLine("3 : Wyszukaj pojazdy");
                        Console.WriteLine("4 : Sprzedaj pojazd");
                        Console.WriteLine("clear : Wyczyść ekran");
                        Console.WriteLine("quit : Wyjdź");
                        option = Console.ReadLine();
                        break;
                    case "clear":
                        Console.Clear();
                        option = "m";
                        break;
                    default:
                        Console.WriteLine("Brak takiej opcji.");
                        Console.WriteLine("Aby zakończyć wpisz q");
                        Console.WriteLine("Aby wyświetlić menu wpisz m");
                        option = Console.ReadLine();
                        break;
                }
            } while (option != "quit");
        }
    }
 
}
