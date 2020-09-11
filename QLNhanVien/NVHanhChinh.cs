using System;

namespace QLNhanVien
{
    class NVHanhChinh : NhanVien
    {
        private double hsLuong;
        private static double luongCB;


        public NVHanhChinh()
        {
            luongCB = 0;
            hsLuong = 0;
        }
        public NVHanhChinh(string maNV, string hoTen, string ngaySinh, string diaChi, string dienThoai, double hsLuong)
            : base(maNV, hoTen, ngaySinh, diaChi, dienThoai)
        {
            this.hsLuong = hsLuong;

        }
        public static double getLuongCB()
        {
            return luongCB;
        }
        public static void setLuongCB(double luong)
        {
            luongCB = luong;
            if (luongCB < 4000000)
                luongCB = luong;
        }
        public double getHSluong()
        {
            return hsLuong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Moi nhap he so luong NV: ");
            hsLuong = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Moi nhap luong co ban NV: ");
            luongCB = Convert.ToDouble(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return hsLuong * luongCB;
        }
        public override string toString()
        {
            return base.toString() + ",HeSoLuong:" + hsLuong;
        }
    }
}
