using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fatorial(num));

            Console.WriteLine("O fatorial de {0} é {1}",num, Fatorial(num));

            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if(num <= 0)
            {
                return 1;
            }

            return num * Fatorial(num - 1);
            //5 * Fatorial(4);
            //4 * Fatorial(3);
            //3 * Fatorial(2);
            //2 * Fatorial(1);
            //1 * Fatorial(0);
            //return 1;
        }
    }
}
