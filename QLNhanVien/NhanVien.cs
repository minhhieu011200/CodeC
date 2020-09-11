using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien
{
    abstract class NhanVien
    {
        protected string maNV;
        protected string hoTen;
        protected string ngaySinh;
        protected string diaChi;
        protected string dienThoai;

        public NhanVien()
        { }
      
        public NhanVien(string maNV, string hoTen, string ngaySinh, string diaChi, string dienThoai)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string getMaNV()
        {
            return maNV;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        public string getNgaySinh()
        {
            return ngaySinh;
        }
        public string getDiaChi()
        {
            return diaChi;
        }
        public string getDienThoai()
        {
            return dienThoai;
        }
        public virtual void Nhap()
        {
            Console.Write("Moi nhap Ma NV: ");
            maNV = Console.ReadLine();
            Console.Write("Moi nhap Ho ten NV: ");
            hoTen = Console.ReadLine();
            Console.Write("Moi nhap Ngay sinh NV: ");
            ngaySinh = Console.ReadLine();
            Console.Write("Moi nhap Dia chi NV: ");
            diaChi = Console.ReadLine();
            Console.Write("Moi nhap Dien thoai NV: ");
            dienThoai = Console.ReadLine();
        }
        public abstract double TinhLuong();
        public virtual string toString()
        {
            return "MANV:" + maNV + ",HoTen: " + hoTen + ",NgaySinh:" + ngaySinh + ",DiaChi: " + diaChi + ",DienThoai:" + dienThoai;
        }

    }
}
