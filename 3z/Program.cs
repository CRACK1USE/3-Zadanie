using System;

namespace _3z
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите p: ");
            float p = float.Parse(Console.ReadLine());

            double x = n * p;

            double y = Math.Pow(x, 3) / 6 * Math.Pow(2.71828, -0.1);
            y = Math.Round(y, 4);
            Console.WriteLine("Вероятность: " + y);
            Console.ReadKey();
        }
    }
}
