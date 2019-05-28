using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLPK.BLL;
using DLPK.Entity;
using DLPK.DAO;
using DLPK.Gui;

namespace DLPK.Gui
{
    public partial class frmThongTinBacSi : Form
    {
        AccountBLL account = new AccountBLL();
        BacSiBLL bacSi = new BacSiBLL();
        private string _TenDN;
        public frmThongTinBacSi()
        {
            InitializeComponent();
        }
        public void LoadThongtin()
        {
            DataTable data =  account.Thongtinbacsi(_TenDN);
            txtTenBS.Text = data.Rows[0]["TenBS"].ToString();
            txtChucVu.Text = data.Rows[0]["ChucVu"].ToString();
            txtGiaTien.Text = data.Rows[0]["GiaTien"].ToString();
            txtTenPK.Text = data.Rows[0]["TenPK"].ToString();
            txtTenKhoa.Text = data.Rows[0]["TenKhoa"].ToString();
            txtGhiChu.Text = data.Rows[0]["GhiChu"].ToString();
        }
        public void LoadLichHen()
        {
            dtgLichHen.DataSource = bacSi.PhieuHen_BacSi(_TenDN);
        }
        public frmThongTinBacSi(string TenDN) : this()
        {
            _TenDN = TenDN;
        }

        private void frmThongTinBacSi_Load(object sender, EventArgs e)
        {
            LoadThongtin();
            LoadLichHen();
        }

        private void btnLichKham_Click(object sender, EventArgs e)
        {
            frmDangKyLichKham frmDangKy = new frmDangKyLichKham(txtTenBS.Text);
            frmDangKy.ShowDialog();
        }
    }
}
