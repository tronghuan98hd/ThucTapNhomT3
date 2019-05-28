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
        //public DataTable ViewBS()
        //{
        //    string query = "BacSi_Select";
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query);
        //    return result;
        //}
        public List<ThoiGian> ViewTime(BacSi bacSi,ThoiGian thoiGian)
        {
            List<ThoiGian> ListThoiGian = new List<ThoiGian>();
            string query = "ThongTinDatPhong N'"+bacSi.TenBS+"' , '"+thoiGian.NgayKham+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                ThoiGian thoigian = new ThoiGian(item);
                ListThoiGian.Add(thoigian);
            }
            return ListThoiGian;
        }
        public DataTable Select_NgayKham(BacSi bacSi)
        {
            string query = "Select_NgayKham N'"+bacSi.TenBS+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable BacSi_ChiTiet(BacSi bacSi)
        {
            string query = "BacSi_ChiTiet N'"+bacSi.TenBS+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable LichHen_BacSi(string TenDN)
        {
            string query = "PhieuHen_BacSi @TenDN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenDN });
            return result;
        }
        public bool ThoiGian_Select(BacSi bacSi,ThoiGian thoiGian )
        {
            string query = "ThoiGian_Select  N'"+bacSi.TenBS+"' , '"+thoiGian.NgayKham+ "' , '" + thoiGian.Time + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
