using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    internal class LenghtOfLine
    {

        public double LenghtLine()
        {

            Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the cartesian coordinates of (x2,y2)");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double Lenght = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return Lenght;
        }
    }
}