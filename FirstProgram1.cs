using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public class FirstProgram1
    {
        // main is not public method
        // Main () M is in capital letter

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"Addition is  {c}");

        }
    }
}
