using System;

namespace TinhLuongNhanVien
{
    public class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        // Constructor khong tham so
        public NhanVien()
        {
            _maNV = "NV000";
            _hoTen = "Chua co ten";
            _luongCoBan = 5000000;
            _soNgayLam = 26;
            _soNgayNghiPhep = 0;
        }

        // Constructor chi co ma NV va ho ten
        public NhanVien(string maNV, string hoTen)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _luongCoBan = 5000000;
            _soNgayLam = 26;
            _soNgayNghiPhep = 0;
        }

        // Constructor day du tham so
        public NhanVien(
            string maNV,
            string hoTen,
            decimal luongCoBan,
            int soNgayLam,
            int soNgayNghiPhep)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            LuongCoBan = luongCoBan;
            SoNgayLam = soNgayLam;
            _soNgayNghiPhep = soNgayNghiPhep;
        }

        // Constructor co Optional Parameters
        public NhanVien(
            string maNV,
            string hoTen,
            decimal luong = 5000000,
            int soNgayLam = 26)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            LuongCoBan = luong;
            SoNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }

        // Property HoTen
        public string HoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
                _hoTen = value;
            }
        }

        // Property LuongCoBan
        public decimal LuongCoBan
        {
            get
            {
                return _luongCoBan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Luong co ban phai >= 0");
                }

                _luongCoBan = value;
            }
        }

        // Property SoNgayLam
        public int SoNgayLam
        {
            get
            {
                return _soNgayLam;
            }
            set
            {
                if (value < 0 || value > 31)
                {
                    throw new ArgumentException(
                        "So ngay lam phai tu 0 den 31");
                }

                _soNgayLam = value;
            }
        }

        // Property LuongThucNhan
        public decimal LuongThucNhan
        {
            get
            {
                decimal khauTruBHXH = LuongCoBan * 8 / 100;

                return LuongCoBan / 26 * SoNgayLam
                       - khauTruBHXH;
            }
        }

        // TinhThuong khong tham so
        public decimal TinhThuong()
        {
            return 0;
        }

        // TinhThuong co he so
        public decimal TinhThuong(decimal heSo)
        {
            return LuongCoBan * heSo;
        }

        // TinhThuong co he so va phuc loi
        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = LuongCoBan * heSo;

            if (coPhucLoi == true)
            {
                thuong += 500000;
            }

            return thuong;
        }

        // Hien thi thong tin
        public void HienThiThongTin()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ma NV: " + _maNV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Luong co ban: " + LuongCoBan.ToString("N0"));
            Console.WriteLine("So ngay lam: " + SoNgayLam);
            Console.WriteLine("Luong thuc nhan: "
                              + LuongThucNhan.ToString("N0"));
            Console.WriteLine("------------------------------");
        }
    }
}