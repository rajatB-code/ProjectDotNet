using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public class Subtraction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int ans = num1 - num2;
            Console.WriteLine($"Subtraction is {ans}");
        }
    }
}
