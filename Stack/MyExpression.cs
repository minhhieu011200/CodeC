using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stack
{
    class MyExpression 
    {
        private string bieuthuc;
        private List<string> TaoListinfix(string bieuthuc)
        {
            List<string> infix = new List<string>();
            string[] infixs = ChuanHoaBieuThuc(bieuthuc).Split(' ');
            foreach (string c in infixs)
            {
                infix.Add(c);
            }

            return infix;
        }

        public string Bieuthuc { get => bieuthuc; set => bieuthuc = value; }
        public MyExpression(string bieuthuc)
        {
            this.bieuthuc = bieuthuc;
        }
        public string ChuanHoaBieuThuc(string bieuthuc)
        {

            string chuanhoa = "";
            bieuthuc = bieuthuc.Replace(" ", "");
            for (int i = 0; i < bieuthuc.Length; i++)
            {
                if (bieuthuc[i] == '+' || bieuthuc[i] == '-' || bieuthuc[i] == '*' || bieuthuc[i] == '/' || bieuthuc[i] == '%')
                {
                    chuanhoa += " " + bieuthuc[i] + " ";
                }
                else chuanhoa += bieuthuc[i];
            }
            chuanhoa = chuanhoa.Trim();
            return chuanhoa;
        }
        public int DoUuTien(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        public bool ToanTu(string str)
        {
            return Regex.Match(str, @"\+|\-|\*|\/|\%").Success;
        }
        public bool ToanHang(string str)
        {
            return Regex.Match(str, @"\d").Success;

        }
        public string InfixtoPostfix(string bieuthuc)
        {
            string result = "";
            IntStack stack = new IntStack(bieuthuc.Count());
            foreach (string c in TaoListinfix(bieuthuc))
            {
                if (ToanHang(c))
                {
                    result += c + " ";
                }
                else if (c == "(")
                {
                    stack.Push(c);
                }
                else if (c == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        result += x + " ";
                        x = stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count() > 0 && DoUuTien(c) <= DoUuTien(stack.Peek()))
                        result += stack.Pop() + " ";
                    stack.Push(c);
                }
            }
            while (stack.Count() > 0)
                result += stack.Pop() + " ";
            result = result.Trim();
            return result;
        }
        private List<string> TaoListPosfit(string bieuthuc)
        {
            List<string> posfit = new List<string>();
            string[] posfits = InfixtoPostfix(bieuthuc).Split(' ');
            foreach (string c in posfits)
            {
                posfit.Add(c);
            }

            return posfit;

        }
        public double Tinh()
        {
            string a = "";
            IntStack stack = new IntStack(bieuthuc.Count());
            foreach (string s in TaoListPosfit(bieuthuc))
            {

                if (ToanHang(s))
                {
                    stack.Push(s);
                }
                else
                {
                    double x = double.Parse(stack.Pop());
                    double y = double.Parse(stack.Pop());
                    switch (s)
                    {
                        case "+": y += x; break;
                        case "-": y -= x; break;
                        case "*": y *= x; break;
                        case "/": y /= x; break;
                        case "%": y %= x; break;
                    }
                    a += y;
                    stack.Push(a);
                    a = "";

                }

            }
            return double.Parse(stack.Peek());

        }
        public void Xuat()
        {
            //foreach(string c in TaoListPosfit(bieuthuc))
            //     Console.Write(c);
            Console.WriteLine(ChuanHoaBieuThuc(bieuthuc));
            Console.WriteLine(Tinh());


        }

    }
}

