using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_2_
{
     class NhanVienVIP : NhanVien
    {
        private double thuong;

        public double Thuong
        {
            get { return thuong; }
        }

        public NhanVienVIP(string ma, string ten, double gio, double luong)
            : base(ma, ten, gio, luong)
        {
            if (gio < 40)
                thuong = 0;
            else if (gio <= 60)
                thuong = luong * 0.1;
            else
                thuong = luong * 0.2;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Thuong,-10}";
        }
    }
}
