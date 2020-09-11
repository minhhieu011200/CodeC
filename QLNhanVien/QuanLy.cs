using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien
{
    class QuanLy
    {
        private List<NhanVien> dsNhanVien = new List<NhanVien>();

        public void NhapDSNhanVien()
        {
            Console.WriteLine("Nhap so luong nhan vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin NV thu {0}", i + 1);
                NhanVien nv;
                nv = new NVHanhChinh();
                nv.Nhap();
                dsNhanVien.Add(nv);
            }
        }
        public void ThemNV(NhanVien nv)
        {
            Console.WriteLine("da them nv: " + nv.toString());
            dsNhanVien.Add(nv);
        }

        public void DSNVsaukhisuachua()
        {
            Console.WriteLine("danh sach nhan vien cuoi cung: ");
            foreach (var x in dsNhanVien)
            {
                Console.WriteLine(x.toString());
                Console.WriteLine(x.TinhLuong());
            }
        }
        public void XoaNV(string maNV)
        {
            int a = -1;
            for (int i = 0; i < dsNhanVien.Count; i++)
            {
                if (dsNhanVien[i].getMaNV() == maNV)
                {
                    a = i;
                    break;
                }
            }
            if (a == -1)
            {
                Console.WriteLine("khong tim thay NV ma so: " + maNV);
            }
            else
            {
                dsNhanVien.RemoveAt(a);
                Console.WriteLine("da xoa NV ma so: " + maNV);
            }
        }
        public void DSNVLuongDuoiTB()
        {
            double luongTB = 0;
            int soLuongNV = dsNhanVien.Count;
            for (int i = 0; i < soLuongNV; i++)
                luongTB += dsNhanVien[i].TinhLuong();
            luongTB = luongTB / soLuongNV;
            Console.WriteLine("Muc luong TB la: {0:0}", luongTB);
            Console.WriteLine("Danh sach nhan vien co luong thap hon muc luong TB la:");
            Console.WriteLine("{0,-20} {1,9}", "Ho Ten", "Luong");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < soLuongNV; i++)
            {
                double luongNV = dsNhanVien[i].TinhLuong();
                if (luongNV < luongTB)
                    Console.WriteLine("{0,-20} | {1,9}", dsNhanVien[i].getHoTen(), luongNV);
            }


        }

    }


}

