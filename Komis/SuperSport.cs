using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    class SuperSport : Suzuki
    {
        public SuperSport(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {
        }

        public override string wyswietlModel() => "Super Sport";
    }
}
