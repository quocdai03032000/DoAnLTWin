using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class FLogin : Form
    {
        DBE dbe = new DBE();
        public FLogin()
        {
            InitializeComponent();
            Init_Data();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user;
            string pass;
            string userF = txbUser.Text;
            string passF = txbPassword.Text;
            var tk = from u in dbe.Accounts select u;
            foreach(var data in tk)
            {
                user = data.User.ToString();
                pass = data.Pass.ToString();
                if (userF == user && passF == pass)
                {
                    FMain main = new FMain();
                    this.Hide();
                    Save_data();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        /*--- Save password  ---*/

        void Save_data()
        {
            if(checkSavePassword.Checked)
            {
                Properties.Settings.Default.UserName = txbUser.Text;
                Properties.Settings.Default.Password = txbPassword.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            } else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }

        void Init_Data()
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.Remme=="yes")
                {
                    txbUser.Text = Properties.Settings.Default.UserName;
                    txbPassword.Text = Properties.Settings.Default.Password;
                    checkSavePassword.Checked = true;
                }
                else
                {
                    txbUser.Text = Properties.Settings.Default.UserName;
                }
            }
        }

    }
}
