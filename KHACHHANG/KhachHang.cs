using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHACHHANG
{
    abstract class KhachHang
    {
        protected int maKH;
        protected string hoTen;
        protected int soLuong;
        protected int donGia;
        protected int dinhMuc;
        protected double thanhTien;

        public KhachHang()
        { }
        public KhachHang(int maKH, string hoTen, int soLuong, int donGia, int dinhMuc)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.dinhMuc = dinhMuc;
            
        }

        public int getmaKH()
        {
            return maKH;
        }
        public void setmaKH(int maKH)
        {
            this.maKH = maKH;
        }

        public string gethoTen()
        {
            return hoTen;
        }
        public void sethoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public int getsoLuong()
        {
            return soLuong;
        }
        public void setsoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }
        public int getdonGia()
        {
            return donGia;
        }
        public void setdonGia(int donGia)
        {
            this.donGia = donGia;
        }
        public int getdinhMuc()
        {
            return dinhMuc;
        }
        public void setdinhMuc(int dinhMuc)
        {
            this.dinhMuc = dinhMuc;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma khach hang ");
            maKH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ho ten ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap so luong ");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap don gia ");
            donGia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc ");
            dinhMuc = Convert.ToInt32(Console.ReadLine());
        }

        public abstract double getThanhTien();

        public virtual string toString()
        {
            return "MaKH=" + maKH + ",HoTen=" + hoTen;
        }
    }
}
