﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursivo r = new Recursivo();
            r.Executar("Ola mundo!", 5);

            Console.WriteLine();
            r.ExecutarRecursivo("Ola mundo!", 5);

            Console.ReadKey();
        }
    }
}