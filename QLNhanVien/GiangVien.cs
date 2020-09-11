using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien
{
    class GiangVien:NhanVien
    {
        private double hsChucDanh;
        private double soTietGiang;
        private static double dgTietGiang;
        public GiangVien()
        { }
        public GiangVien(string maNV, string hoTen, string ngaySinh, string diaChi, string dienThoai,double hsChucDanh,double soTietGiang)
            :base(maNV,hoTen,ngaySinh,diaChi,dienThoai)
        {
            this.hsChucDanh = hsChucDanh;
            this.soTietGiang = soTietGiang;
        }
        public static double getdgTietGiang()
        {
            return dgTietGiang;
        }
        public static void setdgTietGiang(double dgTietGiang)
        {
            dgTietGiang = dgTietGiang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so chuc danh NV: ");
            hsChucDanh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so tiet giang: ");
            soTietGiang = Convert.ToDouble(Console.ReadLine());
        }
        public override string toString()
        {
            return base.toString()+",HSChucDanh: "+hsChucDanh+",SoTietGiang= "+soTietGiang;
        }
        public override double TinhLuong()
        {
            return hsChucDanh * dgTietGiang * soTietGiang;
        }
    }
}
