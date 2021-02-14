using System;
using System.Globalization;
namespace Uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, r,volume;

            pi = 3.14159;


            Console.WriteLine();
            Console.Write("Digite o Raio : ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r = Math.Pow(r,3);

            volume = (double)((4 / 3.0) * pi * r);



            Console.WriteLine();
            Console.WriteLine("O Volume é  : "+volume.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
