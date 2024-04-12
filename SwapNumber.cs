using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public class SwapNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before swapping num1 = {num1}, num2 ={num2}");

            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping num1 = {num1}, num2 ={num2}");


        }
    }
}
