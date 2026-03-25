using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");

            }
        }
    }
}
