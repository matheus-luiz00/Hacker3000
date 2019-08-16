using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4.MyFirstClass
{
    class Carro
    {
        int rodas = 0;
        int portas = 0;
        int bancos = 0;
        public int janelas = 0;

        public int Rodas
        {
            get{ return rodas; }
            set { rodas = value; }
        }

        public static Carro operator ++(Carro carro)
        {
            carro.Rodas = carro.Rodas + 5;
            return carro;
        }

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso carro:\n" +
                $"Quant. Rodas {rodas}\n" +
                $"Quant. Portas {portas}\n" +
                $"Quant. Bancos {bancos}\n" +
                $"Quant. Janelas {janelas} ");
        }

    }
}
