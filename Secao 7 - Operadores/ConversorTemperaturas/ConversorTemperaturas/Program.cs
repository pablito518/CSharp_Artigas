using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");


            // (c * 9 / 5) + 32 = F
            f = (c * 9 / 5) + 32;

            // c + 273,15
            k = c + 273.15;

            Console.WriteLine(c + " Graus Celcius = " + f + " Graus Fahrenheit");
            Console.WriteLine(c + " Graus Celcius = " + k + " Graus Kelvin");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}
