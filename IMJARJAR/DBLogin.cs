using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IMJARJAR
{
    class DBLogin : Database
    {
        public bool loginCheck(string naam, string wachtwoord)
        {
            bool resultaat = false;
            string sql;
            sql = "select * from Klant Where(Klant_naam = @naam and Klant_wachtwoord = @wachtwoord)";

            try
            {
                Connect();

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add(new MySqlParameter("naam", naam));
                cmd.Parameters.Add(new MySqlParameter("wachtwoord", wachtwoord));
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    resultaat = true;
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return resultaat;
        }

        public Account returnLoggedinAccount(string naam)
        {

            Account account = new Account();
            string Klant_adres = "";
            string Klant_woonplaats = "";

            string sql;
            sql = "select * from Klant Where(Klant_naam = @naam)";

            try
            {
                Connect();

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add(new MySqlParameter("naam", naam));
                //cmd.Parameters.Add(new OracleParameter("password", password));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Klant_adres = Convert.ToString(reader["Klant_adres"]);
                    Klant_woonplaats = Convert.ToString(reader["Klant_woonplaats"]);
                }

                account = new Account(new Klant(naam, Klant_adres, Klant_woonplaats));
            }
            catch (MySqlException )
            {

            }
            finally
            {
                connection.Close();
            }
            return account;
        }
    }
}
