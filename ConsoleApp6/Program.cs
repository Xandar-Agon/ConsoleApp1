using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@".\teste");
            FileInfo[] allfiles = dir.GetFiles("*.*");

            foreach(FileInfo f in allfiles)
            {
                Console.WriteLine("Nome do Ficheiro " + f.Name);
                Console.WriteLine("Criado em " + f.CreationTime);
                Console.WriteLine("Tamanho " + f.Length);
            }
        }
    }
}
