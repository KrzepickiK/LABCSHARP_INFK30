using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Pojazd
    {
        private int iRokProdukcji;

        protected Pojazd(float fCenaZakupu, float fMarza, int iRokProdukcji)
        {
            this.CenaZakupu = fCenaZakupu;
            this.Marza = fMarza;
            this.iRokProdukcji = iRokProdukcji;
        }

        public float Marza { get; }
        public float CenaZakupu { get; }
        public float RokProdukcji { get => iRokProdukcji; }

        public void WyswietlRok() {
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
        }
        public float podajCeneKoncowa()
        {
            float cenaKoncowa = CenaZakupu + ((Marza*CenaZakupu)/100);
            return cenaKoncowa;
        }

        public abstract string WyswietlMarke();
        public abstract string WyswietlModel();
        public abstract string WyswietlTypPojazdu { get;}
    }
}
