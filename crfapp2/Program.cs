using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crfapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine(nome +" "+sobrenome);
            Console.ReadKey();
        }
    }
}
