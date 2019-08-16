using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClass;

namespace CalculadoraDLLamigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculos = new Calculadora();

            Console.WriteLine("Retangulo");
            Console.WriteLine(  calculos.AreaRetangulo(10.5f, 10.5f));
            Console.WriteLine();

            Console.WriteLine("Triangulo");
            Console.WriteLine(   calculos.AreaTrianguloEquilatero(10, 10));
            Console.WriteLine();

            Console.WriteLine("Circulo");
            Console.WriteLine(   calculos.RaioCirculo((float)10));
            Console.WriteLine();

            Console.WriteLine("Soma");
            Console.WriteLine(   calculos.Soma(10, 10));
            Console.WriteLine();

            Console.WriteLine("Subtração");
            Console.WriteLine(   calculos.Subtracao(10, 5));
            Console.WriteLine();

            Console.WriteLine("Multiplcação");
            Console.WriteLine(   calculos.Multiplicacao(10, 10));
            Console.WriteLine();

            Console.WriteLine("Divisão");
            Console.WriteLine(   calculos.Divisao(10, 2));


            Console.ReadKey();
        }
    }
}
