using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMJARJAR
{
    public class Account
    {
        public Klant Klant { get; set; }

        public Account(Klant klant)
        {
            this.Klant = klant;
        }

        public Account()
        {

        }
    }
}
