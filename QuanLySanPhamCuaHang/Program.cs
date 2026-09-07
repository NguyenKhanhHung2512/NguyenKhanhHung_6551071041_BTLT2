using System;
using System.Collections.Generic;

namespace QuanLySanPhamCuaHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6551071041");
            // Tao danh sach san pham
            List<SanPham> danhSach = new List<SanPham>
            {
                new SanPham
                {
                    MaSP = "SP001",
                    TenSP = "But bi",
                    Gia = 10000,
                    SoLuongTon = 100
                },

                new SanPhamThucPham
                {
                    MaSP = "TP001",
                    TenSP = "Sua tuoi",
                    Gia = 30000,
                    SoLuongTon = 50,
                    NgayHetHan = DateTime.Now.AddDays(2),
                    NhietDoBAoquan = 5
                },

                new SanPhamDienTu
                {
                    MaSP = "DT001",
                    TenSP = "Laptop",
                    Gia = 20000000,
                    SoLuongTon = 10,
                    BaoHanhThang = 24,
                    HangSanXuat = "Dell"
                }
            };

            decimal tongGiaTriKho = 0;

            Console.WriteLine("========== DANH SACH SAN PHAM ==========");

            foreach (SanPham sp in danhSach)
            {
                decimal giaBan = sp.TinhGiaBan();

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Ma SP: " + sp.MaSP);
                Console.WriteLine("Ten SP: " + sp.TenSP);
                Console.WriteLine("Gia goc: " + sp.Gia.ToString("N0") + " VND");
                Console.WriteLine("So luong ton: " + sp.SoLuongTon);
                Console.WriteLine("Gia ban: " + giaBan.ToString("N0") + " VND");

                Console.WriteLine("Mo ta: " + sp.MoTa());

                // Tinh tong gia tri kho
                tongGiaTriKho += giaBan * sp.SoLuongTon;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine(
                "Tong gia tri kho: "
                + tongGiaTriKho.ToString("N0")
                + " VND"
            );

            Console.ReadKey();
        }
    }
}