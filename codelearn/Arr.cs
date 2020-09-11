using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codelearn
{
    class Arr
    {
        public int k;//{ get => k; set => k = value; }
        public int[] a;// { get => a; set => a = value; }
        public int x;

        public void Nhap()
        {
            k = int.Parse(Console.ReadLine());
            a = new int[k];
            for (int i = 0; i < k; i++)
            { a[i] = int.Parse(Console.ReadLine()); }

        }
        public void Xuat()
        {

            Console.Write("Mang vua nhap là: ");
            for (int i = 0; i < k; i++)
            { Console.Write(a[i] + " "); }
            Console.WriteLine();
            InterchangeSort();
            for (int i = 0; i < k; i++)
            { Console.Write(a[i] + " "); }
            //InterchangeSort();
            //Console.WriteLine(a);
        }
        public int timKiemTuanTu(int x)
        {
            int i = 0;
            while (a[i] != x && i < k - 1)
            { i++; }
            if (a[i] != x)
                return -1;
            else return i + 1;

        }
        public int timKiemNhiPhan(int x)
        {
            int left = 0;
            int right = k - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x) return mid + 1;
                if (a[mid] < x) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        public void HoanVi(ref int a, ref int b)
        {
            if (a > b)
            {
                int tam = a;
                a = b;
                b = tam;
            }
        }
        public void InterchangeSort()
        {
            {
                for (int i = 0; i < k - 1; i++)
                {
                    for (int j = i + 1; j < k; j++)
                        if (a[i] > a[j])
                        {
                            HoanVi(ref a[i], ref a[j]);
                        }
                }
                for(int i=0;i<k;i++)
                Console.WriteLine(a[i]);
            }
        }
        public void Insertsort()
        {
            int post;
            int x;
            for (int i = 0; i < k - 1; i++)
            {

                x = a[i + 1];
                post = i;
                while ((a[post] > x) && (post > 0))
                {
                    a[post + 1] = a[post];
                    post--;
                    a[post + 1] = x;
                }
                while (post == 0 && a[post] > x)
                {
                    a[post + 1] = a[post];
                    a[post] = x;

                }
            }
        }
        }
}
