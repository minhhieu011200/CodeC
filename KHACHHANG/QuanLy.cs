using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHACHHANG
{
    class QuanLy
    {
        private List<KhachHang> dsKhachHang = new List<KhachHang>();
        public void NhapTTKhachHang()
        {
            Console.WriteLine("Nhap so luong khach hang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin khach hang thu {0}:", i + 1);
                KhachHang kh = new KhachHangVN();
                kh.Nhap();
                dsKhachHang.Add(kh);
            }
        }
        public void ThemKH(KhachHang kh)
        {
            Console.WriteLine("da them khach hang: "+kh.toString());
            dsKhachHang.Add(kh);
        }
        public void XoaKH(int maKH)
        {
            int index = -1;
            for (int i = 0; i < dsKhachHang.Count; i++)
            {
                if (dsKhachHang[i].getmaKH() == maKH)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("ko tim thay khach  hang ma so: " + maKH);
            }
            else
            {
                dsKhachHang.RemoveAt(index);
                Console.WriteLine("da xoa khach hang ma so: " + maKH);
            }
        }
        public void dsCuoiCung()
        {
            foreach (var x in dsKhachHang)
            {
                Console.WriteLine(x.toString());
                Console.WriteLine(x.getThanhTien());
            }
        }
    }
}
