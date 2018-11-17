using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Honda : Motocykl
    {
        protected Honda(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string wyswietlMarke() => "Honda";
    }
}
