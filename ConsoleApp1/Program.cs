using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Escreva um número");
            int valor;
            valor = Convert.ToInt16(Console.ReadLine());

            Console.Write(valor.ToString());
            Console.ReadKey();
        }
    }
}