using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMJARJAR
{
    public partial class IMJARJAR : Form
    {
        private Administration admini;

        public IMJARJAR(Administration admin)
        {
            
            InitializeComponent();
            admini = admin;
        }

        private void test()
        {
            dgv_Klant.Rows.Clear();
            try
            {
                foreach (Cursus C in admini.returnAllCursus())
                {
                    dgv_Klant.Rows.Add(C.Cursus_ID, C.Cursus_naam, C.Cursus_omschrijving, C.Cursus_aantal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btn_vull_Click(object sender, EventArgs e)
        {
            test();
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tb_Aantal.Text || tb_ID.Text ||tb_Naam.Text || tb_Om.Text))
            //{
            //    MessageBox.Show("Vul de titel in");
            //    Title = false;

            //}
            //else if (string.IsNullOrEmpty(tbPostText.Text))
            //{
            //    MessageBox.Show("Vul de inhoud in");
            //    Inhoud = false;
            //}

            Cursus cursus = new Cursus(Convert.ToInt32(tb_ID), tb_Naam.Text, Convert.ToInt32(tb_Aantal));
            cursus.Account = admini.currentAccount;
            admini.Add(cursus, tb_Om.Text);
        }
    }
}
