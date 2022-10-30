using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Metodos
    {
        //Metodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo!");
        }

        //Métodos com parâmetros
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }

        //Passagem de parâmetros por valor

        //copia o valor da variável original, ou seja, caso a variável original seja 100 e o método seja chamado,
        //esta alteração não se perpetuará. Ex: v1 = 100 -> método a altera para 110 ->
        //após um Console.WriteLine(v1) o valor será 100.
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por valor) é: " + valor);
        }


        //Passagem de parâmetros por referência

        //Altera o valor da variável original, ou seja, caso a variável original seja 100 e o método seja chamado,
        //esta alteração se perpetuará por todo o programa. Ex: v1 = 100 -> método a altera para 110 ->
        //após um Console.WriteLine(v1) o valor será 110.
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por referência) é: " + valor);
        }

        /* Quando você faz a passagem de dados por valor, o que é feito é uma copia do valor 
         * em outro endereço de memória, é como se estivessemos apresentando um objeto para ser 
         * utilizado, mas ele não utiliza o objeto em sí, o que ele faz é uma copia do objeto 
         * para poder utilizar.
            
           Já na passagem de dados por referência, o que acontece é que ele pega o endereço de memoria
           onde esta aquelw objeto, e com isso ele pode trabalhar com o objeto em sí, e não com uma copia
           do seu valor apenas...*/

        
        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = caractere;
            return caractere;
        }

        public double ValorPi()
        {
            return 3.1415;
           // return Math.PI;
        }

        //Sobrecarga de métodos

        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá {0}", nome);
        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
