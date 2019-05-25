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

namespace DLPK.Gui
{
    public partial class frmThongTinBacSi : Form
    {
        

        private string _TenDN;
        public frmThongTinBacSi()
        {
            InitializeComponent();
        }
        public void LoadThongtin()
        {
           
        }
        public frmThongTinBacSi(string TenDN) : this()
        {
            this._TenDN = TenDN;
        }

    }
}
