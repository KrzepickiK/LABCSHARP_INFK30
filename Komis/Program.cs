using System;
using System.Collections.Generic;

namespace Komis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pojazd panda = new Panda(5000, 10, 1999);
            //Console.WriteLine($"Typ pojazdu: {panda.WyswietlTypPojazdu}" +
            //    $"\nMarka: {panda.WyswietlMarke()} " +
            //    $"\nModel: {panda.WyswietlModel()}" +
            //    $"\nCena zakupu: {panda.CenaZakupu} zł" +
            //    $"\nMarża: {panda.Marza}%" +
            //    $"\nRok produkcji: {panda.RokProdukcji}" +
            //    $"\nCena koncowa: {panda.podajCeneKoncowa()}" +
            //    $"\nNever say no to Panda!! ;)");

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
                            Console.WriteLine(poj.WyswietlTypPojazdu);
                        }
                        option = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Dodaj nowy pojazd.");
                        list.Add(new Panda(5000, 10, 1999));
                        list.Add(new SuperSport(10000, 15, 2005));
                        option = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Wyszukaj pojazd w komisie.");
                        option = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Sprzedaj pojazd.");
                        option = Console.ReadLine();
                        break;
                    case "m":
                        Console.WriteLine("Dostępne opcje:");
                        Console.WriteLine("1 : Wyświetl listę pojazdów");
                        Console.WriteLine("2 : Dodaj nowy pojazd");
                        Console.WriteLine("3 : Wyszukaj pojazdy");
                        Console.WriteLine("4 : Sprzedaj pojazd");
                        Console.WriteLine("q : wyjdź");
                        option = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Brak takiej opcji.");
                        Console.WriteLine("Aby zakończyć wpisz q");
                        Console.WriteLine("Aby wyświetlić menu wpisz m");
                        option = Console.ReadLine();
                        break;
                }
            } while (option != "q");

            //panda.WyswietlRok();
        }
    }
 
}
