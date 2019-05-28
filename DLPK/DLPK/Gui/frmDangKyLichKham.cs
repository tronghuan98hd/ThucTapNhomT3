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
    public partial class frmDangKyLichKham : Form
    {
        BacSiBLL BacSi = new BacSiBLL();
        private string _TenBS;
        public frmDangKyLichKham()
        {
            InitializeComponent();
        }
        public frmDangKyLichKham(string TenBS) : this()
        {
            _TenBS = TenBS;
        }
        public void LoadTenBS()
        {
            lbTenBS.Text = _TenBS;
        }
        public void LoadListBox()
        {
            clbSang.Items.Insert(0, "08:00:00");
            clbSang.Items.Insert(0, "08:30:00");
            clbSang.Items.Insert(0, "09:00:00");
            clbSang.Items.Insert(0, "09:30:00");
            clbSang.Items.Insert(0, "10:00:00");
            clbSang.Items.Insert(0, "10:30:00");
            clbSang.Items.Insert(0, "11:00:00");
            clbSang.Items.Insert(0, "13:30:00");
            clbSang.Items.Insert(0, "14:00:00");
            clbSang.Items.Insert(0, "14:30:00");
            clbSang.Items.Insert(0, "15:00:00");
            clbSang.Items.Insert(0, "15:30:00");
            clbSang.Items.Insert(0, "16:00:00");
            clbSang.Items.Insert(0, "16:30:00");
        }
        public void ListChecked()
        {
            foreach(string s in clbSang.CheckedItems)
            {
                BacSi bacSi = new BacSi(-1, lbTenBS.Text, "", -1, -1, -1, "");
                ThoiGian thoiGian = new ThoiGian(-1, s, dtgNgayKham.Value.ToString("MM/dd/yyyy"), -1);
                BacSi.ThoiGian_Insert(bacSi, thoiGian);
            }
        }
        private void frmDangKyLichKham_Load(object sender, EventArgs e)
        {
            LoadTenBS();
            LoadListBox();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ListChecked();
        }
    }
}
