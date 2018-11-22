using System;
using System.Collections.Generic;

namespace Komis
{
    class Program
    {
        static void Main(string[] args)
        {
            Pojazd panda = new Panda(5000, 10, 1999);

            Console.WriteLine($"Typ pojazdu: {panda.wyswietlTypPojazdu}" +
                $"\nMarka: {panda.WyswietlMarke()} " +
                $"\nModel: {panda.WyswietlModel()}" +
                $"\nCena zakupu: {panda.CenaZakupu} zł" +
                $"\nMarża: {panda.Marza}%" +
                $"\nRok produkcji: {panda.RokProdukcji}" +
                $"\nCena koncowa: {panda.podajCeneKoncowa()}" +
                $"\nNever say no to Panda!! ;)");

            panda.WyswietlRok();
        }
    }
}
