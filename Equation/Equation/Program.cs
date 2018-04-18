using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo các biến sử dụng trong chương trình
            float a, b, result;

            //Nhập hệ số a
            Console.Write("Enter a:");
            a = float.Parse(Console.ReadLine());

            //Nhập hệ số b
            Console.Write("Enter b:");
            b = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Equation countless solutions.");
                else
                    Console.WriteLine("The equation has no solution.");
            }
            else
            {
                result = -b / a;
                Console.WriteLine("The solution of the equation is {0}.", result);
            }

            Console.ReadLine();
        }
    }
}


