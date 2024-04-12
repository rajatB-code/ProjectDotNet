using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo1
{
    public class PercentageFiveSub
    {
        static void Main(string[] args)
        {
            double totalMarks = 500;
            double sub1, sub2, sub3, sub4, sub5;

            double totalObtainMarks, percentage;

            Console.WriteLine("Enter Marks for Subject 1 : ");
            sub1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 2 : ");
            sub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 3 : ");
            sub3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 4 : ");
            sub4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 5 : ");
            sub5 = Convert.ToDouble(Console.ReadLine());

            totalObtainMarks  =  sub1 + sub2 + sub3 + sub4 + sub5;

            percentage = (totalObtainMarks / totalMarks) * 100;

            Console.WriteLine($"total Obtain Marks : {totalObtainMarks}");
            Console.WriteLine($"Percentage : {percentage}%");
        }
    }
}
