using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como te chamas?");
            string nome = Console.ReadLine();
            int space = nome.IndexOf(" ");
            Console.WriteLine(nome.Substring(space+1));
            Console.Read();
            Console.WriteLine("O teu nome tem {0} caracteres", nome.Length);
        }
    }
}
