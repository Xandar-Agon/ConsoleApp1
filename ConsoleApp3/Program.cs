using System;

namespace ConsoleApp3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Insere o valor de x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insere o valor de y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor maior é {0} ", Math.Max(x, y));

            Console.WriteLine("{0} elevado a {1} é {2}",x,y,Math.Pow(x, y));

            Console.WriteLine("A raíz quadrada de {0} é {1}", x,Math.Sqrt(x));

            Console.Read();
        }
    }
}