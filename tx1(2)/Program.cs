using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx1_2_
{
    internal class Program
    {
        static List<NhanVien> ds = new List<NhanVien>();

        static void Main(string[] args)
        {
            int chon;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Tim nhan vien");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon: ");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Nhap();
                        break;
                    case 2:
                        HienThi();
                        break;
                    case 3:
                        Tim();
                        break;
                    case 4:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!");
                        break;
                }

            } while (chon != 4);
        }

        static void Nhap()
        {
            Console.WriteLine("1. Nhan vien");
            Console.WriteLine("2. Nhan vien VIP");
            Console.Write("Chon: ");
            int loai = int.Parse(Console.ReadLine());

            Console.Write("Ma NV: ");
            string ma = Console.ReadLine();

            if (ds.Any(x => x.MaNV == ma))
            {
                Console.WriteLine("Trung ma!");
                return;
            }

            Console.Write("Ho ten: ");
            string ten = Console.ReadLine();

            Console.Write("So gio lam: ");
            double gio = double.Parse(Console.ReadLine());

            Console.Write("Luong co ban: ");
            double luong = double.Parse(Console.ReadLine());

            if (loai == 1)
                ds.Add(new NhanVien(ma, ten, gio, luong));
            else if (loai == 2)
                ds.Add(new NhanVienVIP(ma, ten, gio, luong));
            else
                Console.WriteLine("Loai khong hop le!");
        }

        static void HienThi()
        {
            Console.WriteLine();

            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-12}{4,-12}{5,-10}",
                "Ma", "Ho ten", "So gio", "Luong CB", "Luong", "Thuong");

            foreach (NhanVien nv in ds)
            {
                if (nv is NhanVienVIP vip)
                {
                    Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-12}{4,-12}{5,-10}",
                        vip.MaNV,
                        vip.HoTen,
                        vip.SoGioLam,
                        vip.LuongCoBan,
                        vip.TinhLuong(),
                        vip.Thuong);
                }
                else
                {
                    Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-12}{4,-12}{5,-10}",
                        nv.MaNV,
                        nv.HoTen,
                        nv.SoGioLam,
                        nv.LuongCoBan,
                        nv.TinhLuong(),
                        "");
                }
            }
        }

        static void Tim()
        {
            Console.Write("Nhap ma can tim: ");
            string ma = Console.ReadLine();

            NhanVien nv = ds.FirstOrDefault(x => x.MaNV == ma);

            if (nv == null)
            {
                Console.WriteLine("Khong tim thay!");
                return;
            }

            if (nv is NhanVienVIP vip)
            {
                Console.WriteLine("Nhan vien VIP:");
                Console.WriteLine(vip);
            }
            else
            {
                Console.WriteLine("Nhan vien:");
                Console.WriteLine(nv);
            }
        
    }
    }
}
