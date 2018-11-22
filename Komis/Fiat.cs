using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Fiat : Samochod
    {
        protected Fiat(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string WyswietlMarke() => "Fiat";
    }
}
