using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNomes = new string[5, 2];

            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                listaDeNomes[i, 0] = i.ToString();
                listaDeNomes[i, 1] = $"Salve_Guri_{i}";
            }

            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaDeNomes[i, 0]} | Nome: {listaDeNomes[i, 1]}");
                
            }

            Console.ReadLine();
        }
    }
}
