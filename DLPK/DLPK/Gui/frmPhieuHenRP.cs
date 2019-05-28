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
namespace DLPK.Gui
{
    public partial class frmPhieuHenRP : Form
    {
        PhieuHenBLL phieuHen = new PhieuHenBLL();
        public frmPhieuHenRP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenBN = txtTenBN.Text;
            int SDT = Convert.ToInt32(txtSDT.Text);
            DataTable data = phieuHen.PhieuHenChiTiet(TenBN,SDT);
            try
            {
                DateTime NgayKham = Convert.ToDateTime(data.Rows[0]["NgayKham"].ToString());
                lbTenBN.Text = data.Rows[0]["TenBN"].ToString();
                lbGioiTinh.Text = data.Rows[0]["GioiTinh"].ToString();
                lbNamSinh.Text = data.Rows[0]["NamSinh"].ToString();
                lbSDT.Text = data.Rows[0]["SDT"].ToString();
                lbTenBS.Text = data.Rows[0]["TenBS"].ToString();
                lbPhongKham.Text = data.Rows[0]["TenPK"].ToString();
                lbDiaChi.Text = data.Rows[0]["DiaChi"].ToString();
                lbNgayKham.Text = NgayKham.ToString("dd/MM/yyyy");
                lbGioKham.Text = data.Rows[0]["ThoiGian"].ToString();
                lbGiaKham.Text = data.Rows[0]["GiaTien"].ToString();
            }
            catch (Exception)
            { MessageBox.Show("Không tồn tại dữ liệu bạn vừa nhập,vui lòng kiểm tra lại", "Thông báo"); }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TenBS = lbTenBS.Text;
            string TenBN = lbTenBN.Text;
            if (MessageBox.Show("Bạn có thực sự muốn hủy??", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (phieuHen.PhieuHen_Delete(TenBS, TenBN))
                    MessageBox.Show("Hủy thành công vui lòng kiểm tra lại","Thông báo");
                else
                    MessageBox.Show("Hủy thất bại");
            }
        }
    }
}
