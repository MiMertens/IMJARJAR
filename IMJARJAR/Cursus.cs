using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMJARJAR
{
    public class Cursus
    {
        public Account Account { get; set; }

        public int Cursus_ID { get; set; }

        public string Cursus_naam { get; set; }

        public string Cursus_omschrijving { get; set; }

        public int Cursus_aantal { get; set; }

        public Cursus(int Cursus_ID, string Cursus_naam, string Cursus_omschrijving, int Cursus_aantal)
        {
            this.Cursus_ID = Cursus_ID;
            this.Cursus_naam = Cursus_naam;
            this.Cursus_omschrijving = Cursus_omschrijving;
            this.Cursus_aantal = Cursus_aantal;
        }

        public Cursus(int Cursus_ID, string Cursus_naam, int Cursus_aantal)
        {
            this.Cursus_ID = Cursus_ID;
            this.Cursus_naam = Cursus_naam;
            this.Cursus_aantal = Cursus_aantal;
        }
    }
}
