using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_2_
{
     class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double soGioLam;
        private double luongCoBan;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public double SoGioLam
        {
            get { return soGioLam; }
            set { soGioLam = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public NhanVien() { }

        public NhanVien(string ma, string ten, double gio, double luong)
        {
            MaNV = ma;
            HoTen = ten;
            SoGioLam = gio;
            LuongCoBan = luong;
        }

        public virtual double TinhLuong()
        {
            return SoGioLam * LuongCoBan;
        }

        public override string ToString()
        {
            return $"{MaNV,-10}{HoTen,-20}{SoGioLam,-10}{LuongCoBan,-12}{TinhLuong(),-12}";
        }
    }
}
