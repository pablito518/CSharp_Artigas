using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class Program
    {
        enum MyEnum
        {
            Opção = 1
        }
        static void Main(string[] args)
        {
            #region Switch - Case
            //int escolha = 3;

            //switch (escolha)
            //{
            //    default:
            //        Console.WriteLine("Opção default");
            //        break;

            //    case 1:
            //        Console.WriteLine("Opção 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("Opção 2");
            //        break;

            //    case 3:
            //    case 4:
            //        Console.WriteLine("Opção combinada");
            //        break;
            //}
            #endregion

            #region Declaração Goto
            //Inicio:
            //    Console.WriteLine("Escolha uma opção: ");
            //    int op = int.Parse(Console.ReadLine());
            //    int valor = 0;

            //    switch (op)
            //    {
            //        default:
            //            goto Inicio;
            //        //     break;
            //        case 1:
            //            valor += 100;
            //            break;
            //        case 2:
            //            valor += 100;
            //            goto case 1;
            //    }
            #endregion


            Console.ReadKey();
        }
    }
}
