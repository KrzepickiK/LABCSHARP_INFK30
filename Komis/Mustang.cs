using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    class Mustang : Ford
    {
        public Mustang(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {

        }

        public override string WyswietlModel() => "Mustang";
    }
}
