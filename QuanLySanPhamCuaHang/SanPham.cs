using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        // Constructor khong tham so
        public SanPham()
        {
            _maSP = "";
            _tenSP = "";
            _gia = 0;
            _soLuongTon = 0;
        }

        // Constructor day du
        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _gia = gia;
            _soLuongTon = soLuongTon;
        }

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public decimal Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return "San pham thong thuong";
        }
    }
}