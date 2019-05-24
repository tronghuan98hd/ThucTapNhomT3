using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLPK.Entity;
using System.Data;

namespace DLPK.DAO
{
    public class PhieuHenDAO
    {
        private static PhieuHenDAO instance;
        public static PhieuHenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuHenDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public PhieuHenDAO() { }

        public bool PhieuHen_Insert(BacSi bacSi, BenhNhan benhNhan, PhieuHen phieuHen)
        {
            try
            {
                string query = "BenhNhan_Select N'" + bacSi.TenBS + "',N'" + benhNhan.TenBN + "','" + phieuHen.ThoiGian + "','" + phieuHen.NgayKham + "',N'" + phieuHen.GhiChu + "',N'" + benhNhan.GioiTinh + "','" + benhNhan.NgaySinh + "','" + benhNhan.SDT + "','" + benhNhan.Email + "',N'" + benhNhan.DiaChi + "'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                return true;
            }
            catch(Exception e)
            { }
            return false;
        }
        public DataTable PhieuHenChiTiet(string TenBN,int SDT)
        {
            string query = "PhieuHenChiTiet @TenBN , @SDT";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenBN, SDT });
            return result;
        }
    }
}
