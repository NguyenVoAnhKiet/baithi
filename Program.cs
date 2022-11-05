using System;
namespace baithi
{
    class PhongBan
    {
        internal int dienthoai;
        internal string maphong;
        internal string tenphong;
        internal NhanVien matruongphong;
        internal LinkedList<NhanVien> nhanviens;
        internal DateTime nambonhiem;
        public PhongBan(int dienthoai, string maphong, string tenphong)
        {
            this.dienthoai = dienthoai;
            this.maphong = maphong;
            this.tenphong = tenphong;
            this.nhanviens = new LinkedList<NhanVien>();
        }
        public void ThemNV(LinkedList<NhanVien> dsnv)
        {
            foreach (NhanVien nhanvien in dsnv)
            {
                if (nhanvien.phongban.maphong == maphong)
                {
                    nhanviens.AddLast(nhanvien);
                }
            }
        }
        
        public void LietKeNVPB()
        {
            foreach (NhanVien nhanvien in nhanviens)
            {
                nhanvien.Output();
            }
        }
        public void ThemTruongPhong(NhanVien nhanvien,string nambonhiem)
        {
            this.matruongphong=nhanvien;
            this.nambonhiem=DateTime.Parse(nambonhiem);
           
        }
        public void InfoTtruongPhong()
        {
            Console.WriteLine($"{matruongphong.hoten} {nambonhiem.ToShortDateString()}");
        }
    }
    class NhanVien
    {
        internal string masv;
        internal string hoten;
        internal DateTime ngaysinh;
        internal double hsluong;
        //internal NhanVien nvql;
        internal PhongBan phongban;
        public NhanVien(string masv, string hoten, string ngaysinh, double hsluong)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = DateTime.Parse(ngaysinh);
            this.hsluong = hsluong;
        }
        public void ThemPB(PhongBan phongban)
        {
            this.phongban = phongban;
        }
        public void Output()
        {
            Console.WriteLine($"{hoten}");
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
            internal DateTime ngaythamgia;
            internal TimeSpan songaycong;
            public ThamGia(NhanVien manv, HangMuc mahm, string ngaythamgia)
            {
                this.manv = manv;
                this.mahm = mahm;
                this.ngaythamgia = DateTime.Parse(ngaythamgia);
                this.songaycong = DateTime.Now.Subtract(this.ngaythamgia);
            }
        }
    }
    class Test
    {
        static LinkedList<NhanVien> dsnv = new LinkedList<NhanVien>();
        static LinkedList<PhongBan> dspb= new LinkedList<PhongBan>();
        static void ThongTinTruongPhong()
        {
            foreach(PhongBan truongphong in dspb)
            {
                truongphong.InfoTtruongPhong();
            }
        }
        static void Main()
        {

            PhongBan pb1 = new PhongBan(123456789, "PB1", "Phong nhan su");
            dspb.AddLast(pb1);
            NhanVien nv1 = new NhanVien("NV1", "Anh Kiet", "4 9 2003", 3.0);
            NhanVien nv2 = new NhanVien("NV2", "Nhu Quynh", "02 01 2003", 4.0);
            dsnv.AddLast(nv1);
            dsnv.AddLast(nv2);
            nv1.ThemPB(pb1);
            nv2.ThemPB(pb1);
            pb1.ThemNV(dsnv);
            pb1.LietKeNVPB();
            pb1.ThemTruongPhong(nv1,"7 2 2003");
            ThongTinTruongPhong();
        }
    }
}