using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Area {0}", area);
        }
    }

    class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um círculo");
        }

        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area Circulo {0}", area);
        }
    }

    class Retangulo : Forma
    {
        public override void Desenhar()
        {
            //Code to draw a Rectangle...
            base.Desenhar();
            Console.WriteLine("Desenhando um Retangulo");
        }

        public override void Area()
        {
            base.Area();
        }
    }

    class Triangulo : Forma
    {
        public override void Desenhar()
        {
            //Code to draw a Triangle...
            base.Desenhar();
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            double area = (Largura * Altura) / 2;
            Console.WriteLine("Area Retangulo {0}", area);
        }
    }
}
