using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Write("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            n2 = double.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Esses números são iguais");
            }
            else
            {
                Console.WriteLine("Esses números não são iguais");
            }
        }
    }
}
