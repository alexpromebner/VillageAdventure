using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VillageAdventure
{
    public partial class frm_login : Form
    {
        public static int id;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_newaccount_Click(object sender, EventArgs e)
        {
            frm_newAccount frm = new frm_newAccount();
            frm.ShowDialog();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chck_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_showPassword.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
            SQLInteraction.CreateDatabase("a.promebner_VillageAdventure");
            SQLInteraction.CreateTable("a.promebner_VillageAdventure", "Login");


            
        }

        public void txt_username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SQLInteraction.CheckTable("Login", txt_username.Text, txt_password.Text);

            id = SQLInteraction.GetID("Login", txt_username.Text, "Id");

            //MessageBox.Show(id.ToString());
            SQLInteraction.con.Close();

            frm_doodlejump frm = new frm_doodlejump();
            frm.ShowDialog();
        }
    }
}
