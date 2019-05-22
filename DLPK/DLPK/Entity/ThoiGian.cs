using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPK.Entity
{
    public class ThoiGian
    {
        private int _MaTG;
        private string _Time;
        private string _NgayKham;
        private int _MaBS;
        
        public ThoiGian()
        {
            _MaTG = -1;
            _Time = "";
            _NgayKham = "";
            _MaBS = -1;
        }
        public ThoiGian(int MaTG,string Time,string NgayKham,int MaBS)
        {
            this._MaTG = MaTG;
            this._Time = Time;
            this._NgayKham = NgayKham;
            this._MaBS = MaBS;
        }
        public ThoiGian(DataRow row)
        {
            //this._MaTG = (int)row["MaTG"];
            this._Time = row["ThoiGian"].ToString();
            //this._MaBS = (int)row["MaBS"];
        }
        public int MaTG
        {
            set
            {
                this._MaTG = value;
            }
            get
            {
                return this._MaTG;
            }
        }
        public string Time
        {
            set
            {
                this._Time = value;
            }
            get
            {
                return this._Time;
            }
        }
        public string NgayKham
        {
            set
            {
                this._NgayKham = value;
            }
            get
            {
                return this._NgayKham;
            }
        }
        public int MaBS
        {
            set
            {
                this._MaBS = value;
            }
            get
            {
                return this._MaBS;
            }
        }
    }
}
