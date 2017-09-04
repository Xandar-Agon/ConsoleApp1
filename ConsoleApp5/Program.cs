using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passaste {0} argumentos", args.Length);

            System.Threading.Thread.Sleep(3000);

            for(int i = 0; i< args.Length; i++)
            {
                Console.WriteLine("{0} - \t {1}", i, args[i]);
            }
        }
    }
}
