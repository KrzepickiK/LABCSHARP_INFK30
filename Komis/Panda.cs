using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    class Panda : Fiat
    {
        public Panda(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string WyswietlModel() => "Panda";
    }
}
