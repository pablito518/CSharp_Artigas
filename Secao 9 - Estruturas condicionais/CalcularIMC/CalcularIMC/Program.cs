using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / Math.Pow(altura, 2); //(altura*altura)

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC.ToString("F2", CultureInfo.InvariantCulture) + " -> Abaixo do peso.");
            }
            else if((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC " + valorIMC.ToString("F2", CultureInfo.InvariantCulture) + " -> Peso normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\nIMC " + valorIMC.ToString("F2", CultureInfo.InvariantCulture) + " -> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("\nIMC " + valorIMC.ToString("F2", CultureInfo.InvariantCulture) + " -> Obeso.");
            }
            else
            {
                Console.WriteLine("\nIMC " + valorIMC.ToString("F2", CultureInfo.InvariantCulture) + " -> Muito obeso.");
            }
            Console.ReadKey();
        }
    }
}
