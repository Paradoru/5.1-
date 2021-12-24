using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());
            double z = 0;
            z += Program.Sin(x, y);
            Console.WriteLine("{0:F2}", z);
        }
        static double Sin(double a, double s)
        {
            double z = 0;
            double x = Math.Sin(a);
            double y = Math.Sin(s);
            if (a < 0)
            {
                x = -1;
            }
            if (a == 0)
            {
                x = 0;
            }
            if (a > 0)
            {
                x = 1;
            }
            if (s < 0)
            {
                y = -1;
            }
            if (s == 0)
            {
                y = 0;
            }
            if (s > 0)
            {
                y = 1;
            }
            z += x + y;
            return z;
        }
    }
}
