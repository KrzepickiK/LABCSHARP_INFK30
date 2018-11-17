using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    class Ranger : Ford
    {
        public Ranger(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string wyswietlModel() => "Ranger";
    }
}
