using DoAnCuoiKi.NewFolder1;
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
    public partial class ChangePass : Form
    {
        
        public ChangePass()
        {
            InitializeComponent();
        }

        private void checkHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkHidePass.Checked==true)
            {
                txbMKcu.UseSystemPasswordChar = false;
                txbMKmoi.UseSystemPasswordChar = false;
            } else
            {
                txbMKcu.UseSystemPasswordChar = true;
                txbMKmoi.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {


            DBE change = new DBE();
            string OldPass = txbMKcu.Text;
            Account lg = change.Accounts.Where(t => t.Pass == OldPass).SingleOrDefault();
            
            if (lg != null && txbMKmoi.Text !="")
            {
                string qtr = "update dbo.Account set Pass = '" + txbMKmoi.Text + "'";
                DataTable rpIn = DataProvider.Instance.ExecuteQuery(qtr);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Không thể thực hiện ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
