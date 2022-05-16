using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LenghtOfLine obj1 = new LenghtOfLine();
            double Lenght1 = obj1.LenghtLine();
            double Lenght2 = obj1.LenghtLine();

            Console.WriteLine("The lenght of the two points of line-1: " + Lenght1);
            Console.WriteLine("The lenght of the two points of line-2: " + Lenght2);
            if (Lenght1 < Lenght2)
            {
                Console.WriteLine("Line-1 is less than line-2");
            }
            else
            {
                if (Lenght2 < Lenght1)
                {
                    Console.WriteLine("Line-1 is Greater than line-2");
                }
                else
                {
                    Console.WriteLine("Line-1 is equal to line-2");
                }
            }
        }
    }
}
