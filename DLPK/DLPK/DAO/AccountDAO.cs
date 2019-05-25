using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLPK.DAO
{
    public class AccountDAO
    {
        private static AccountDAO istance;

        public static AccountDAO Istance
        {
            get
            {
                if (istance == null)
                    istance = new AccountDAO();
                return istance;
            }
            private set { istance = value; }
        }
        public AccountDAO() { }
        public bool Login(string TenDN, string MatKhau)
        {
            string query = "sp_Login @TenDN , @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenDN , MatKhau });
            return result.Rows.Count > 0;
        }
        public DataTable Thongtinbacsi(string TenDN)
        {
            string query = "Thongtinbacsi @TenDN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenDN });
            return result;
        }
    }
}
