using System;

namespace QuanLySachCoBan
{
    public class Sach
    {
        // Khai bao field private
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        // Constructor day du tham so
        public Sach(string maSach, string tenSach, string tacGia,
                    int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            TenSach = tenSach;
            _tacGia = tacGia;
            NamXuatBan = namXuatBan;
            _giaBan = giaBan;
        }

        // Constructor khong tham so
        public Sach()
        {
            _maSach = "S001";
            _tenSach = "Chua co ten";
            _tacGia = "Chua xac dinh";
            _namXuatBan = DateTime.Now.Year;
            _giaBan = 0;
        }

        // Property MaSach: chi doc tu ben ngoai
        public string MaSach
        {
            get { return _maSach; }
        }

        // Property TenSach: doc/ghi, khong duoc rong
        public string TenSach
        {
            get { return _tenSach; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ten sach khong duoc de trong!");
                }

                _tenSach = value;
            }
        }

        // Property NamXuatBan: doc/ghi, tu 1900 den nam hien tai
        public int NamXuatBan
        {
            get { return _namXuatBan; }
            set
            {
                int namHienTai = DateTime.Now.Year;

                if (value < 1900 || value > namHienTai)
                {
                    throw new ArgumentException(
                        $"Nam xuat ban phai tu 1900 den {namHienTai}!");
                }

                _namXuatBan = value;
            }
        }

        // Property TacGia
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }

        // Property GiaBan: chi doc tu ben ngoai
        public double GiaBan
        {
            get { return _giaBan; }
        }

        // Hien thi thong tin sach
        public void HienThiThongTin()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("           THONG TIN SACH");
            Console.WriteLine("========================================");
            Console.WriteLine($"Ma sach      : {MaSach}");
            Console.WriteLine($"Ten sach     : {TenSach}");
            Console.WriteLine($"Tac gia      : {TacGia}");
            Console.WriteLine($"Nam xuat ban : {NamXuatBan}");
            Console.WriteLine($"Gia ban      : {GiaBan:N0} VND");
            Console.WriteLine("========================================");
        }

        // Override ToString()
        public override string ToString()
        {
            return $"[{MaSach}] {TenSach} - {TacGia} - " +
                   $"{NamXuatBan} - {GiaBan:N0} VND";
        }
    }
}
