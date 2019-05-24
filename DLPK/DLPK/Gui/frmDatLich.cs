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
using System.Globalization;

namespace DLPK.Gui
{
    public partial class frmDatLich : Form
    {
        PhieuHenBLL phieuhen = new PhieuHenBLL();
        private string _TenBS;
        private string _ThoiGian;
        private string _NgayKham;
        public frmDatLich()
        {
            InitializeComponent();
        }
        public frmDatLich(string TenBS,string ThoiGian,string NgayKham) :this()
        {
            _TenBS = TenBS;
            _ThoiGian = ThoiGian;
            _NgayKham = NgayKham;
        }

        private void frmDatLich_Load(object sender, EventArgs e)
        {
            lbTenBS.Text = _TenBS;
            lbThoiGian.Text = _ThoiGian;
            lbNgay.Text = _NgayKham;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string TenBN = txtTenBN.Text;
            string GT = txtGioiTinh.Text;
            string NgaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy");
            int SDT = Convert.ToInt32(txtSDT.Text);
            string Email = txtEmail.Text;
            string DiaChi = txtDiaChi.Text;
            string GhiChu = txtGhiChu.Text;
            string NgayKham = lbNgay.Text;
            string[] formats = {"dd/MM/yyyy", "dd-MMM-yyyy", "yyyy-MM-dd",
                   "dd-MM-yyyy", "M/d/yyyy", "dd MMM yyyy"};
            string converted = DateTime.ParseExact(NgayKham, formats, CultureInfo.InvariantCulture, DateTimeStyles.None).ToString("MM/dd/yyyy");
            BacSi bacSi = new BacSi(-1, lbTenBS.Text, "", -1, -1, -1, "");
            BenhNhan benhNhan = new BenhNhan(-1, TenBN, GT, NgaySinh, SDT, Email, DiaChi);
            PhieuHen phieuHen = new PhieuHen(-1, -1, lbThoiGian.Text, GhiChu, converted);
            if(phieuhen.PhieuHen_Insert(bacSi, benhNhan, phieuHen)==true)
            {
                MessageBox.Show("Đặt lịch thành công!","Thông báo");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
