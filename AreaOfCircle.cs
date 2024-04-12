using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public  class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.WriteLine("Enter the Radius of the Circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area =  3.14 * radius * radius;

            Console.WriteLine($"The area of Circle with radius is {radius} is : {area}" );
        }
    }
}
