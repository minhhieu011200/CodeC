using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocThi
{
    class ThiSinh
    {
        private int soBaoDanh;
        private string hoTen;
        private int bai1;
        private int bai2;
        private int bai3;
        private int tong;

        protected int SoBaoDanh { get => soBaoDanh; set => soBaoDanh = value; }
        protected string HoTen { get => hoTen; set => hoTen = value; }
        protected int Bai1 { get => bai1; set => bai1 = value; }
        protected int Bai2 { get => bai2; set => bai2 = value; }
        protected int Bai3 { get => bai3; set => bai3 = value; }
        protected int Tong
        {
            get { return tong; }
            set { value = bai1 + bai2 + bai3;tong = value; }
        }
        public ThiSinh() { }
        public ThiSinh(int soBaoDanh, string hoTen, int bai1, int bai2, int bai3)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.bai1 = bai1;
            this.bai2 = bai2;
            this.bai3 = bai3;
        }
        public string toString()
        {
            return "So bao danh: " + soBaoDanh + " - HoTen: " + hoTen + "\nTong diem: " + Tong;
        }
    }
}
