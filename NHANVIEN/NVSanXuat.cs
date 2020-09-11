using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIEN
{
    class NVSanXuat : NhanVien
    {
        private int soLuong = 0;
        public static readonly int tienCong = 1000;
        public NVSanXuat() { }
        public NVSanXuat(string maNV, string hoTen, int soLuong) : base(maNV, hoTen)
        {
            this.SoLuong = soLuong;
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public override double TinhLuong()
        {
            int kq = this.soLuong * tienCong;
            if (soLuong > 3000)
                kq = (int)(kq * 1.05);
            return kq;
        }
        public override string toString()
        {
            return base.toString() + "\nLuong: " + TinhLuong();
        }
    }
}
