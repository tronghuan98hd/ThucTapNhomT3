using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLPK.Gui
{
    public partial class frmDatLich : Form
    {
        private string _TenBS;
        private string _ThoiGian;
        public frmDatLich()
        {
            InitializeComponent();
        }
        public frmDatLich(string TenBS,string ThoiGian) :this()
        {
            _TenBS = TenBS;
            _ThoiGian = ThoiGian;
        }

        private void frmDatLich_Load(object sender, EventArgs e)
        {
            lbTenBS.Text = _TenBS;
            lbThoiGian.Text = _ThoiGian;
        }
    }
}
