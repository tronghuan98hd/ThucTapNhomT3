using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLPK.Entity;

namespace DLPK.DAO
{
    public class BacSiDAO
    {
        private static BacSiDAO instance;
        public static int TimeWight = 50;
        public static int TimeHight = 50;
        public static BacSiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BacSiDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BacSiDAO() { }
        public List<BacSi> BacSi_Select(ChuyenKhoa chuyenKhoa)
        {
            List<BacSi> ListBacSi = new List<BacSi>();
            string query = "BacSi_Select_Khoa N'"+chuyenKhoa.TenKhoa+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                BacSi Bacsi = new BacSi(item);
                ListBacSi.Add(Bacsi);
            }
            return ListBacSi;
        }
        public DataTable ViewBS()
        {
            string query = "BacSi_Select";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public List<ThoiGian> ViewTime(BacSi bacSi)
        {
            List<ThoiGian> ListThoiGian = new List<ThoiGian>();
            string query = "ThongTinDatPhong N'"+bacSi.TenBS+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                ThoiGian thoigian = new ThoiGian(item);
                ListThoiGian.Add(thoigian);
            }
            return ListThoiGian;
        }
        public bool PhieuHen_Insert(BacSi bacSi, BenhNhan benhNhan, PhieuHen phieuHen)
        {
            try
            {
                string query = "BenhNhan_Select '" + bacSi.TenBS + "','" + benhNhan.TenBN + "','" + phieuHen.ThoiGian + "','" + phieuHen.GhiChu + "','" + benhNhan.GioiTinh + "','" + benhNhan.NgaySinh + "','" + benhNhan.SDT + "','" + benhNhan.Email + "','" + benhNhan.DiaChi + "'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                return true;
            }
            catch (Exception e)
            { }
            return false;
        }
    }
}
