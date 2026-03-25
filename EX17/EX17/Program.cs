using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, aumento;

            Console.Write("Digite seu salário: ");
            n1 = double.Parse(Console.ReadLine());

            aumento = n1 * 1.10;

            if (n1 < 2000)
            {
                Console.WriteLine("Seu salário com aumento é: " + aumento);
            }
            else
            {
                Console.WriteLine("Seu salário é: " + n1);
            }
        }
    }
}