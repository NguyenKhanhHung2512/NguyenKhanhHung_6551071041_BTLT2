using System;

namespace TinhLuongNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6551071041");
            // Nhan vien 1
            // Su dung constructor khong tham so
            NhanVien nv1 = new NhanVien();

            nv1.HoTen = "Nguyen Van An";
            nv1.LuongCoBan = 8000000;
            nv1.SoNgayLam = 26;


            // Nhan vien 2
            // Su dung constructor ma NV + ho ten
            NhanVien nv2 = new NhanVien(
                "NV002",
                "Tran Thi Binh"
            );

            nv2.LuongCoBan = 10000000;
            nv2.SoNgayLam = 24;


            // Nhan vien 3
            // Su dung constructor day du
            NhanVien nv3 = new NhanVien(
                "NV003",
                "Le Van Cuong",
                12000000,
                28,
                2
            );


            // Hien thi thong tin
            Console.WriteLine("===== NHAN VIEN 1 =====");
            nv1.HienThiThongTin();

            Console.WriteLine("===== NHAN VIEN 2 =====");
            nv2.HienThiThongTin();

            Console.WriteLine("===== NHAN VIEN 3 =====");
            nv3.HienThiThongTin();


            // Su dung Named Arguments
            // voi constructor Optional Parameters
            NhanVien nv4 = new NhanVien(
                maNV: "NV004",
                hoTen: "Pham Thi Dung",
                soNgayLam: 20
            );

            Console.WriteLine("===== NHAN VIEN 4 =====");
            nv4.HienThiThongTin();


            // Goi 3 overload TinhThuong
            Console.WriteLine("===== TINH THUONG =====");

            decimal thuong1 = nv1.TinhThuong();

            decimal thuong2 = nv1.TinhThuong(0.1m);

            decimal thuong3 = nv1.TinhThuong(0.1m, true);


            Console.WriteLine(
                "TinhThuong(): "
                + thuong1.ToString("N0")
                + " VND"
            );

            Console.WriteLine(
                "TinhThuong(0.1): "
                + thuong2.ToString("N0")
                + " VND"
            );

            Console.WriteLine(
                "TinhThuong(0.1, true): "
                + thuong3.ToString("N0")
                + " VND"
            );


            // So sanh
            Console.WriteLine("\n===== SO SANH =====");

            if (thuong1 > thuong2 && thuong1 > thuong3)
            {
                Console.WriteLine("TinhThuong() cao nhat.");
            }
            else if (thuong2 > thuong3)
            {
                Console.WriteLine("TinhThuong(heSo) cao nhat.");
            }
            else
            {
                Console.WriteLine(
                    "TinhThuong(heSo, coPhucLoi) cao nhat."
                );
            }

            Console.ReadKey();
        }
    }
}