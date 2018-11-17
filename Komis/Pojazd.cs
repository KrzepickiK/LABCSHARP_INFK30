using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Pojazd
    {
        private float fCenaZakupu;
        private float fMarza;
        private int iRokProdukcji;

        protected Pojazd(float fCenaZakupu, float fMarza, int iRokProdukcji)
        {
            this.fCenaZakupu = fCenaZakupu;
            this.fMarza = fMarza;
            this.iRokProdukcji = iRokProdukcji;
        }

        public float Marza { get => fMarza; }
        public float CenaZakupu { get => fCenaZakupu; }
        public float RokProdukcji { get => iRokProdukcji; }

        public void WyswietlRok() {
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
        }
        public float podajCeneKoncowa()
        {
            float cenaKoncowa = CenaZakupu + ((Marza*CenaZakupu)/100);
            return cenaKoncowa;
        }

        public abstract string wyswietlMarke();
        public abstract string wyswietlModel();
        public abstract string wyswietlTypPojazdu { get; }
    }
}
