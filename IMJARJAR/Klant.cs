using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMJARJAR
{
    public class Klant
    {
        public string Klant_naam { get; set; }

        public string Klant_adres { get; set; }

        public string Klant_woonplaats { get; set; }


        public Klant(string Klant_naam, string Klant_adres, string Klant_woonplaats)
        {
            this.Klant_naam = Klant_naam;
            this.Klant_adres = Klant_adres;
            this.Klant_woonplaats = Klant_woonplaats;
        }
    }
}
