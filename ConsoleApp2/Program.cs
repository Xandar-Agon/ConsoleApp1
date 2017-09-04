using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random Rand1 = new Random();
            int guess;
            int Num = Rand1.Next(1, 5);

            do
            {
                Console.WriteLine("Introduza um numero de 1 a 5");
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess == Num)
                {
                    Console.WriteLine("Acertaste");
                }
                else
                {
                    Console.WriteLine("És um nabo");
                }
            } while (guess != Num);
        }
    }
}