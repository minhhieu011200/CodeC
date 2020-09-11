using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHACHHANG
{
    class KhachHangVN:KhachHang
    {
        private string doiTuong;

        public KhachHangVN()
        { }
        public KhachHangVN(int maKH, string hoTen, int soLuong, int donGia, int dinhMuc,string doiTuong):base(maKH,hoTen,soLuong,donGia,dinhMuc)
        {
            this.doiTuong=doiTuong;
        }
        public string getdoiTuong()
        {
            return doiTuong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doi tuong: ");
            doiTuong = Console.ReadLine();
        }

        public override double getThanhTien()
        {
            if (soLuong <= dinhMuc)
                return thanhTien = soLuong * donGia;
            else return thanhTien = dinhMuc * donGia + (soLuong - dinhMuc) * 2000 * 2.5;
        }
        
        public override string toString()
        {
            return base.toString()+",DoiTuong="+doiTuong;
        }

    }
}
