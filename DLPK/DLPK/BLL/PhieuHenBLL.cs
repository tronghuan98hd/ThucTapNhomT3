using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLPK.DAO;
using DLPK.Entity;

namespace DLPK.BLL
{
    public class PhieuHenBLL
    {
        private static PhieuHenBLL instance;

        public static PhieuHenBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuHenBLL();
                return instance;
            }
            private set { instance = value; }
        }
        public PhieuHenBLL() { }
        PhieuHenDAO phieuhen = new PhieuHenDAO();
        public bool PhieuHen_Insert(BacSi bacSi, BenhNhan benhNhan, PhieuHen phieuHen)
        {
            return phieuhen.PhieuHen_Insert(bacSi, benhNhan, phieuHen);
        }
    }
}
