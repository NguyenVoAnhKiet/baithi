using System;
namespace baithi
{
    class PhongBan
    {
        internal int dienthoai;
        internal string maphong;
        internal string tenphong;
        public PhongBan(int dienthoai, string maphong, string tenphong)
        {
            this.dienthoai = dienthoai;
            this.maphong = maphong;
            this.tenphong = tenphong;
        }
    }
    class NhanVien
    {
        internal string masv;
        internal string hoten;
        internal DateTime ngaysinh;
        internal double hsluong;
        public NhanVien(string masv, string hoten, string ngaysinh, double hsluong)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = DateTime.Parse(ngaysinh);
            this.hsluong = hsluong;
        }
        class CongTrinh
        {
            internal DateTime ngaykc;
            internal DateTime ngaycgp;//cap giay phep
            internal string mact;
            internal string tenct;
            internal DateTime ngayht;
            internal string diachi;
            internal double tongkp;
            public CongTrinh(string ngaykc, string ngaycgp, string mact, string tenct, string ngayht, string diachi, double tongkp)
            {
                this.ngaykc = DateTime.Parse(ngaykc);
                this.ngaycgp = DateTime.Parse(ngaycgp);
                this.mact = mact;
                this.tenct = tenct;
                this.ngayht = DateTime.Parse(ngayht);
                this.diachi = diachi;
                this.tongkp = tongkp;
            }
        }
        class HangMuc
        {
            internal string mahm;
            internal string tenhm;
            internal double kinhphihm;
            public HangMuc(string mahm, string tenhm, double kinhphihm)
            {
                this.mahm = mahm;
                this.tenhm = tenhm;
                this.kinhphihm = kinhphihm;
            }
        }
        class ThamGia
        {
            internal NhanVien manv;
            internal HangMuc mahm;
            internal double songaycong;
            public ThamGia(NhanVien manv, HangMuc mahm, double songaycong)
            {
                this.manv = manv;
                this.mahm = mahm;
                this.songaycong = songaycong;
            }
        }
    }
}