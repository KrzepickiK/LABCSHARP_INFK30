using System;
using System.Collections.Generic;
using System.Text;

namespace Komis
{
    abstract class Samochod : Pojazd
    {
        protected Samochod(float fCenaZakupu, float fMarza, int iRokProdukcji) : base(fCenaZakupu, fMarza, iRokProdukcji)
        {

        }

        public override string wyswietlTypPojazdu => "Samochód";
    }
}
