using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMJARJAR
{
    public class Administration
    {
        public Account currentAccount { get; set; }

        private DBQuery dbquery = new DBQuery();
        private DBLogin dblogin = new DBLogin();

        public void setCurrentAccount(string naam)
        {
            this.currentAccount = dblogin.returnLoggedinAccount(naam);
        }

        public bool login(string username, string password)
        {
            return dblogin.loginCheck(username, password);
        }

        //Select
        public List<Cursus> returnAllCursus()
        {
            List<Cursus> resultaat = new List<Cursus>();
            resultaat = dbquery.allCursus();
            return resultaat;
        }

        //Insert
        public void Add(Cursus Cursus, string Inhoud)
        {
            DBQuery.InsertCursus(Cursus, Inhoud);
        }
        //Delete

    }
}
