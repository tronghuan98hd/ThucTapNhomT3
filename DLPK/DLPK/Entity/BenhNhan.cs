using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPK.Entity
{
    public class BenhNhan
    {
        private int _MaBN;
        private string _TenBN;
        private string _GioiTinh;
        private string _NgaySinh;
        private int _SDT;
        private string _Email;
        private string _DiaChi;
        public BenhNhan()
        {
            _MaBN = -1;
            _TenBN = "";
            _GioiTinh = "";
            _NgaySinh = "";
            _SDT = -1;
            _Email = "";
            _DiaChi = "";
        }
        public BenhNhan(int MaBN, string TenBN, string GioiTinh, string NgaySinh, int SDT, string Email, string DiaChi)
        {
            this._MaBN = MaBN;
            this._TenBN = TenBN;
            this._GioiTinh = GioiTinh;
            this._NgaySinh = NgaySinh;
            this._SDT = SDT;
            this._Email = Email;
            this._DiaChi = DiaChi;
        }
        public int MaBN
        {
            get
            {
                return this._MaBN;
            }
            set
            {
                this._MaBN = value;
            }
        }
        public string TenBN
        {
            get
            {
                return this._TenBN;
            }
            set
            {
                this._TenBN = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return this._GioiTinh;
            }
            set
            {
                this._GioiTinh = value;
            }
        }
        public string NgaySinh
        {
            get
            {
                return this._NgaySinh;
            }
            set
            {
                this._NgaySinh = value;
            }
        }
        public int SDT
        {
            get
            {
                return this._SDT;
            }
            set
            {
                this._SDT = value;
            }
        }
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return this._DiaChi;
            }
            set
            {
                this._DiaChi = value;
            }
        }
    }
}
