using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager_player
{
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
        }

        // xu ly dang nhap
        private void btn_login_Click(object sender, EventArgs e)
        {
            //mac dinh mk la dung
        
            if(Tb_userName.Text.Trim() == "Team 7" && Tb_password.Text.Trim() == "12345"){
                Main_body Form_main = new Main_body();
                this.Hide();
                Form_main.ShowDialog();
                this.Show();
        }
            else
            {
                MessageBox.Show("Wrong User name or PassWord");
            }
}

        // xu ly thoat
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // this.Close();
            DialogResult check_out = MessageBox.Show("Do you really want to quit?", "Notification", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (check_out == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_showPassword.Checked == true)
            {
                Tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                Tb_password.UseSystemPasswordChar = true;
            }

        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }
    }
}
