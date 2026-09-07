using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBAoquan;

        // Constructor khong tham so
        public SanPhamThucPham() : base()
        {
            _ngayHetHan = DateTime.Now;
            _nhietDoBAoquan = 0;
        }

        // Constructor day du
        public SanPhamThucPham(
            string maSP,
            string tenSP,
            decimal gia,
            int soLuongTon,
            DateTime ngayHetHan,
            int nhietDoBAoquan)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = ngayHetHan;
            _nhietDoBAoquan = nhietDoBAoquan;
        }

        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }

        public int NhietDoBAoquan
        {
            get { return _nhietDoBAoquan; }
            set { _nhietDoBAoquan = value; }
        }

        public override decimal TinhGiaBan()
        {
            TimeSpan khoangCach = _ngayHetHan - DateTime.Now;

            if (khoangCach.TotalDays <= 3 && khoangCach.TotalDays >= 0)
            {
                return Gia * 0.7m;
            }

            return Gia;
        }

        public override string MoTa()
        {
            return $"Thuc pham - Han su dung: {NgayHetHan:dd/MM/yyyy}, " +
                   $"Nhiet do bao quan: {NhietDoBAoquan} do C";
        }
    }
}