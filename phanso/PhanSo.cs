using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanso
{
    class PhanSo
    {
        private int tuso;
        private int mauso;

        public int Tuso { get => tuso; set => tuso = value; }
        public int Mauso { get => mauso; set => mauso = value; }

        public PhanSo()
        {
            Tuso = 0;
            Mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.Tuso = tuso;
            this.Mauso = mauso;
        }
        private int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }
        private void RutGon()
        {
            int ucln = UCLN(Tuso, Mauso);
            Tuso = Tuso / ucln;
            Mauso = Mauso / ucln;
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            Tuso = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so: ");
                Mauso = Convert.ToInt32(Console.ReadLine());
            }
            while (Mauso == 0);

        }
        public void In()
        {
            Console.Write("{0}/{1}", Tuso, Mauso);
        }
        public string toString()
        {
            return Tuso + "/" + Mauso;
        }

        public void nhan(PhanSo a, PhanSo b)
        {
            Tuso = b.Tuso * a.Tuso;
            Mauso = b.Mauso * a.Mauso;
            RutGon();
            Console.WriteLine("{0}/{1}", Tuso, Mauso);
        }
        public void chia(PhanSo a, PhanSo b)
        {
            Tuso = a.Tuso * b.Mauso;
            Mauso = a.Mauso * b.Tuso;
            RutGon();
            Console.WriteLine("{0}/{1}", Tuso, Mauso);
        }
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            PhanSo p = new PhanSo();
            p.Tuso = b.Tuso * a.Mauso + b.Mauso * a.Tuso;
            p.Mauso = b.Mauso * a.Mauso;
            p.RutGon();
            return p;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo p = new PhanSo();
            p.Tuso = b.Tuso * a.Mauso - b.Mauso * a.Tuso;
            p.Mauso = b.Mauso * a.Mauso;
            p.RutGon();
            return p;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo p = new PhanSo();
            p.Tuso = b.Tuso * a.Tuso;
            p.Mauso = b.Mauso * a.Mauso;
            p.RutGon();
            return p;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo p = new PhanSo();
            p.Tuso = a.Tuso * b.Mauso;
            p.Mauso = a.Mauso * b.Tuso;
            p.RutGon();
            return p;
        }
     
        public void sosanh(PhanSo a, PhanSo b)
        {
            if (a.tuso * a.Mauso < 0 && b.tuso * b.Mauso > 0)
                Console.WriteLine("{0}/{1}<{2}/{3}", a.tuso, a.Mauso, b.tuso, b.Mauso);
            else if (a.tuso * a.Mauso > 0 && b.tuso * b.Mauso < 0)
                Console.WriteLine("{0}/{1}>{2}/{3}", a.tuso, a.Mauso, b.tuso, b.Mauso);
            else
            {
                int c = a.Tuso * b.Mauso;
                int d = a.Mauso * b.tuso;
                if (c > d)
                    Console.WriteLine("{0}/{1}>{2}/{3}", a.tuso, a.Mauso, b.tuso, b.Mauso);
                else if (c == d)
                    Console.WriteLine("{0}/{1}={2}/{3}", a.tuso, a.Mauso, b.tuso, b.Mauso);
                else Console.WriteLine("{0}/{1}<{2}/{3}", a.tuso, a.Mauso, b.tuso, b.Mauso);
            }
        }









    }
}
