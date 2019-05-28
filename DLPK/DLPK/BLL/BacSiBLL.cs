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
    public class BacSiBLL
    {
        private static BacSiBLL instance;

        public static BacSiBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BacSiBLL();
                return instance;
            }
            private set { instance = value; }
        }
        public BacSiBLL() { }
        BacSiDAO Bacsi = new BacSiDAO();
        public List<BacSi> BacSi_Select(ChuyenKhoa chuyenKhoa)
        {
            return Bacsi.BacSi_Select(chuyenKhoa);
        }
        //public DataTable ViewBS()
        //{
        //    return Bacsi.ViewBS();
        //}
        public List<ThoiGian> ViewTime(BacSi bacSi,ThoiGian thoiGian)
        {
            return Bacsi.ViewTime(bacSi,thoiGian);
        }
        public DataTable Select_NgayKham(BacSi bacSi)
        {
            return Bacsi.Select_NgayKham(bacSi);
        }
        public DataTable BacSi_ChiTiet(BacSi bacSi)
        {
            return Bacsi.BacSi_ChiTiet(bacSi);
        }
        public DataTable PhieuHen_BacSi(string TenDN)
        {
            return Bacsi.LichHen_BacSi(TenDN);
        }
        public bool ThoiGian_Insert(BacSi bacSi,ThoiGian thoiGian)
        {
            return Bacsi.ThoiGian_Select(bacSi, thoiGian);
        }
    }
}
