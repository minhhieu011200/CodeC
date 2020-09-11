using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private string diaChi;
        private int soNam;

        public SinhVien()
        { }

        public SinhVien(string maSV, string hoTen, string diaChi, int soNam)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.soNam = soNam;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoNam { get => soNam; set => soNam = value; }

        public void Nhap()
        {
            Console.Write("Moi nhap Ma SV: ");
            maSV = Console.ReadLine();
            Console.Write("Moi nhap Ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Moi nhap Dia Chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Sinh vien nam: ");
            soNam = Convert.ToInt32(Console.ReadLine());

            while (soNam > 4 || soNam<=0)
            {
                Console.WriteLine("Vui long nhap lai sinh vien nam: ");
                soNam = Convert.ToInt32(Console.ReadLine());
            }
        }

        public string toString()
        {
            return "MA SV:" + maSV + ", HoTenSV: " + hoTen + ", Dia Chi: " + diaChi + ", SinhVienNam:" + sinhvienNam;
        }
    }
}
