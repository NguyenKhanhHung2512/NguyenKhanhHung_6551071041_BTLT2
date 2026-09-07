using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;

        // Constructor không tham số
        public SanPhamDienTu() : base("", "", 0, 0)
        {
            _baoHanhThang = 0;
            _hangSanXuat = "";
        }

        // Constructor đầy đủ
        public SanPhamDienTu(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            int baoHanhThang,
            string hangSanXuat
        ) : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = baoHanhThang;
            _hangSanXuat = hangSanXuat;
        }

        public int BaoHanhThang
        {
            get { return _baoHanhThang; }
            set { _baoHanhThang = value; }
        }

        public string HangSanXuat
        {
            get { return _hangSanXuat; }
            set { _hangSanXuat = value; }
        }

        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
            {
                return Gia * 1.1m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return $"Dien tu - Hang san xuat: {HangSanXuat}, " +
                   $"Bao hanh: {BaoHanhThang} thang";
        }
    }
}