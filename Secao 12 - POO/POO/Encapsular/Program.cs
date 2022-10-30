using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Gabriel";
            //c._saldo = 100;

            //=============== Operação de Deposito ===============\\
            double valor = 100;
            c.Depositar(valor);

            //=============== Operação de Deposito ===============\\
            double valor2 = 50;
            c.Sacar(valor2);

            //=============== Resultado saldo atual ===============\\
            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
