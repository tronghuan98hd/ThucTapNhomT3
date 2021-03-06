﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPK.Entity
{
    public class PhieuHen
    {
        private int _MaBN;
        private int _MaBS;
        private string _ThoiGian;
        private string _GhiChu;
        private string _NgayKham;
        public PhieuHen()
        {
            _MaBN = -1;
            _MaBS = -1;
            _ThoiGian = "";
            _GhiChu = "";
            _NgayKham = "";
        }
        public PhieuHen(int MaBN,int MaBS,string ThoiGian,string GhiChu,string NgayKham)
        {
            this._MaBN = MaBN;
            this._MaBS = MaBS;
            this._ThoiGian = ThoiGian;
            this._GhiChu = GhiChu;
            this._NgayKham = NgayKham;
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
        public int MaBS
        {
            get
            {
                return this._MaBS;
            }
            set
            {
                this._MaBS = value;
            }
        }
        public string ThoiGian
        {
            get
            {
                return this._ThoiGian;
            }
            set
            {
                this._ThoiGian = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return this._GhiChu;
            }
            set
            {
                this._GhiChu = value;
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
    }
}
