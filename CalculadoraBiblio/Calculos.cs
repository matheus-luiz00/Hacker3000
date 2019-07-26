using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBiblio
{
    public class Calculos
    {
        public double AreaRetangulo(double h, double w)
        {
            return h * w;
        }

        public double AreaTrianguloBaseAlt(double baseT, double altura)
        {
            return ((baseT * altura) / 2);
        }

        public double RaioCirculoCircunferencia(double circunferencia)
        {
            return (circunferencia / (2 * Math.PI));
        }

        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Diminuir(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
