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
    public class AccountBLL
    {
        private static AccountBLL instance;

        public static AccountBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBLL();
                return instance;
            }
            private set { instance = value; }
        }
        public AccountBLL() { }
        AccountDAO login = new AccountDAO();
        public bool Login(string TenDN,string MatKhau)
        {
            return login.Login(TenDN, MatKhau);
        }
        public DataTable Thongtinbacsi(string TenDN)
        {
            return login.Thongtinbacsi(TenDN);
        }
    }
}
