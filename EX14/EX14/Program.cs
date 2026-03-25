using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior número é: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O maior número é: " + n2);
            }
            else
            {
                Console.WriteLine("O maior número é: " + n3);

            }
    }
}
}
