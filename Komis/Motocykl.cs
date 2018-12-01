using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Motocykl : Pojazd
    {

        protected Motocykl(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {

        }

        public override string WyswietlTypPojazdu => "Motocykl";
    }
}
