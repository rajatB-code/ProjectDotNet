using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            double b , h , area;

            Console.WriteLine("Enter the base of the triangle :  ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENter the Height of the triangle :  ");
            h = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * b * h;
            Console.WriteLine($"The area of Triangle is : {area}");
        }
    }
}
