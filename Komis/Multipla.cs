using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    class Multipla : Fiat
    {
        public Multipla(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string WyswietlModel() => "Multipla";
    }
}
