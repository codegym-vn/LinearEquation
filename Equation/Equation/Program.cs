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
            //Nhập hệ số a
            Console.Write("Enter a:");
            float a = float.Parse(Console.ReadLine());

            //Nhập hệ số b
            Console.Write("Enter b:");
            float b = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("The equation has no solution.");
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Equation number of solutions");
                }
                else
                {
                    float result = -b / a;
                    Console.WriteLine("The solution of the equation is {0}", result);
                }
            }
            Console.ReadLine();
        }
    }
}


