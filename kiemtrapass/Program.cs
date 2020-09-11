using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrapass
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                string pass = Console.ReadLine();
                bool checkPassLenght = false;
                bool checkToUpper = false;
                bool checkToLower = false;
                bool checkToNumber = false;
                if (pass.Length >= 8)
                {
                    checkPassLenght = true;
                    count++;
                }
                else Console.WriteLine("khong du 8 ki tu");
                
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]) && checkToUpper == false)
                    {
                        checkToUpper = true;
                        count++;
                    }

                    if (char.IsLower(pass[i]) && checkToLower == false)
                    {
                        checkToLower = true;
                        count++;
                    }

                    if (char.IsNumber(pass[i]) && checkToNumber == false)
                    {
                        checkToNumber = true;
                        count++;
                    }

                }
                if (checkPassLenght && checkToLower && checkToNumber && checkToUpper)

                {
                    Console.WriteLine("-1");
                    break;
                }
                if(checkToLower==false)
                    Console.WriteLine("khong co chu viet thuong");
                if(checkToUpper==false)
                    Console.WriteLine("khong co chu viet hoa");
                if(checkToNumber==false)
                    Console.WriteLine("khong co so");

                    
            }
            while (count != 4);


            }
    }
    }
