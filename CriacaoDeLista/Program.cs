using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[10]; //Cria um array de tipo string

            for (int i = 0; i < lista.Length; i++) //Preenche o array
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }

            //Escreve os dados do array no console
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            for (int i = 0; i < lista.Length; i++) lista[i] = string.Empty;

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
