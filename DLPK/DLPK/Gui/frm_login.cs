using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLPK.Entity;
using DLPK.BLL;

namespace DLPK.Gui
{
    public partial class frm_login : Form
    {

        public frm_login()
        {
            InitializeComponent();
        }
        AccountBLL account = new AccountBLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TenDN = txtTenDN.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            if (account.Login(TenDN,MatKhau))
            {
                frmThongTinBacSi frmThongTinBacSi = new frmThongTinBacSi();
                this.Hide();
                frmThongTinBacSi.ShowDialog(txtTenDN.Text.Trim());
                this.Show();
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo");
        }
    }
}
