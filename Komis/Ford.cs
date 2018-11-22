using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Ford : Samochod
    {
        protected Ford(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string WyswietlMarke() => "Ford";
    }
}
