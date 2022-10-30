using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        enum Notas { 
            Minimo = 10,
            Media = 20, 
            Maxima = 30
        }
        
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            ////Integral assinado
            //sbyte num1 = 10; //8 bits, de -128 a 127
            //short num2 = 20; //16 bits, de -32.768 a 32.767
            //int num3 = 30; //32 bits, de -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; //64 bits, de -9.223.372.036.854.775.808 a 9.223.372.036.836.854.775.807 

            ////Integral sem sinal
            //byte num5 = 10; //8 bits, intervalo de 0 a 255
            //ushort num6 = 10; //16 bits, intervalo de 0 a 65.535
            //uint num7 = 10; //32 bits, intervalo de 0 a 4.294.967.295
            //ulong num8 = 10; //64 bits, intervalo de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Números reais
            //float real1 = 100.75f; // 32 bits, intervalo de 1,5 x 10^-45 a 3,4 x 1038, precisão de 7 digitos => sufixo f, Ex.: 10.5f
            //double real2 = 500.754; // 64 bits, intervalo de 5,0 x 10^-324 a 1,7 x 10308, precisão de 15 digitos => sufixo d (opcional) Ex.: 10.5d
            //decimal real3 = 752538.457m; // 128 bits, intervalo de pelo menos -7,9 x 10^-28 a 7,9 x 1028, com precisão de pelo menos 28 digitos => sufixo m Ex.: 10.5m 

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0061'; //letra a
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = @"Gabriel Artigas\n1985 @@@??$$"; //o "@" faz com que o "\n" não seja lido como caractere de escape, mas
            //                                                 //sim como um caractere individual
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implícito Var
            //var valor = 100;
            //valor = 20;
            //valor = "Gabriel";
            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj = false;
            //obj = 200;
            //obj = "Gabriel";
            #endregion

            #region Constantes
            //const double pi = 3.1415;
            //const string nome = "Gabriel";
            #endregion

            #region Enumeração
            //Notas notasAlunos = Notas.Media;
            #endregion

            #region Struct
            Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 35;
            p1.nome = "Gabriel";

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 9,
                altura = 1.35
            };

            p1.nome = "Logan";
            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();
        }
    }
}
