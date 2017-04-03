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
    public partial class Login : Form
    {
        private Administration admin = new Administration();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (admin.login(tb_GN.Text, tb_WW.Text))
            {
                admin.setCurrentAccount(tb_GN.Text);
                this.Hide();
                new IMJARJAR(admin).Show();                             
            }
        }
    }
}
