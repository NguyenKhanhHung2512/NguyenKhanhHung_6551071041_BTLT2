using System;

namespace QuanLySachCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tao sach bang constructor day du
            Sach sach1 = new Sach(
                "S001",
                "Lap trinh C# co ban",
                "Nguyen Van A",
                2024,
                150000
            );

            // Hien thi thong tin
            sach1.HienThiThongTin();

            // Su dung ToString()
            Console.WriteLine("\nThong tin tom tat:");
            Console.WriteLine(sach1.ToString());

            // Tao sach bang constructor khong tham so
            Sach sach2 = new Sach();

            Console.WriteLine("\nSach mac dinh:");
            sach2.HienThiThongTin();

            // Test thay doi TenSach
            sach2.TenSach = "Lap trinh huong doi tuong";

            // Test thay doi NamXuatBan
            sach2.NamXuatBan = 2025;

            Console.WriteLine("\nSau khi cap nhat:");
            sach2.HienThiThongTin();

            Console.ReadKey();
        }
    }
}
