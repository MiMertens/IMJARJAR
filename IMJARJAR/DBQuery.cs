using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IMJARJAR
{
    class DBQuery : Database
    {
        //Select
        public List<Cursus> allCursus()
        {
            List<Cursus> resultaat = new List<Cursus>();
            string sql;
            sql = "select * from Cursus";

            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    resultaat.Add(new Cursus(Convert.ToInt32(reader["Cursus_ID"]), Convert.ToString(reader["Cursus_naam"]), Convert.ToString(reader["Cursus_omschrijving"]), Convert.ToInt32(reader["Cursus_aantal"])));
                }
            }
            catch (MySqlException ex)
            {
                // The connection failed. Display an error message  
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return resultaat;
        }
        //Insert
        public bool InsertCursus(Cursus Cursis_ID, string Inhoud)
        {
            //throw new System.NotImplementedException();
            bool resultaat = true;
            string sql;
            //CHECKEN OF DIE GOED IS?
            sql = "insert into bericht(postid, inhoud) values (:postid, :inhoud)";

            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                //cmd.Parameters.Add(new MySqlParameter("postid", ));
                //cmd.Parameters.Add(new MySqlParameter("inhoud", ));
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                resultaat = false;
            }
            finally
            {
                connection.Close();
            }
            return resultaat;

        }

    }
}
