using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples.Calculadoras
{
    public class CalculadoraSimplesMesmo
    {
        public float Somar(float valor1, float valor2)
        {
            return valor1 + valor2;
        }

        public float Diminuir(float valor1, float valor2)
        {
            return valor1 - valor2;
        }

        public float Dividir(float valor1, float valor2)
        {
            return valor1 / valor2;
        }

        public float Multiplicar(float valor1, float valor2)
        {
            return valor1 * valor2;
        }
    }
}
