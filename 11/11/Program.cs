using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite seu número");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0) Console.WriteLine("seu numero é positivo");
            if (numero < 0) Console.WriteLine("seu numero é negativo");
            if (numero == 0)
            {
                Console.WriteLine("Seu numero é nulo");
            }
        }
    }
}