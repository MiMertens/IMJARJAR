using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IMJARJAR
{
    public abstract class Database
    {
        protected MySqlConnection connection = new MySqlConnection();
        protected string connectionString = "Server=localhost;port=3307;Database=cursus;Uid=root;password=usbw";


        public Database()
        {

        }

        public void Connect()
        {
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch (Exception ex)
            {
                //uitcommenten in productie
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                connection.Close();
            }
            finally
            {
                //connection.Close();
            }
        }

        public void DisConnect()
        {
            connection.Close();
        }
    }
}
